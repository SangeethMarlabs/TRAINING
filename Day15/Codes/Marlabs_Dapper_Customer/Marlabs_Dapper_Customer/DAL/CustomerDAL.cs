using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Marlabs_Dapper_Customer.Models;
using Marlabs_Dapper_Customer.Repository;
using Microsoft.Extensions.Configuration;

namespace Marlabs_Dapper_Customer.DAL
{
    public class CustomerDAL : ICustomerRepository
    {
        private readonly IConfiguration configuration;

        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(configuration.GetConnectionString("DapperConnection"));
            }
        }

        public CustomerDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int AddCustomer(Customer Customer)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CustName", Customer.CustName);
                param.Add("@CustAddress", Customer.CustAddress);
                param.Add("@CustContactNo", Customer.CustContactNo);

                rowAffected = con.Execute("AddCustomer", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }

        public int DeleteCustomer(int custId)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CustId", custId);
                rowAffected = con.Execute("DeleteCustomer", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }


        public List<Customer> GetAllCustomers()
        {
            using (IDbConnection con = connection)
            {
                String query = "select * from Customer";
                con.Open();
                var result = con.Query<Customer>(query);
                return result.ToList<Customer>();
            }
        }
        public List<Customer> GetAllCustomersold()
        {
            using (IDbConnection con = connection)
            {
                con.Open();
                string query = "select * from Customer";
                var result = con.Query<Customer>(query);
                con.Close();
                return result.ToList<Customer>();
            }
        }

        public Customer GetById(int ID)
        {
            using (IDbConnection con = connection)
            {
                String query = "select * from Customer where CustId=@CustId";
                con.Open();
                var result = con.QueryFirst<Customer>(query, new { @CustId = ID });
                return result;
            }
        }

        public int UpdateCustomer(Customer Customer)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@CustId", Customer.CustId);
                param.Add("@CustName", Customer.CustName);
                param.Add("@CustAddress", Customer.CustAddress);
                param.Add("@CustContactNo", Customer.CustContactNo);

                rowAffected = con.Execute("UpdateCustomer", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }
    }
}
