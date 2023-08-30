using System;
using System.Collections.Generic;
using Marlabs_Dapper.Repository;
using Marlabs_Dapper.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Marlabs_Dapper.DAL
{
    public class EmployeeDAL : IEmployeeRepository
    {
        private readonly IConfiguration configuration;

        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(configuration.GetConnectionString("DapperConnection"));
            }
        }

        public EmployeeDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int AddEmployee(Employee employee)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EmpName", employee.EmpName);
                param.Add("@EmpAge", employee.EmpAge);
                param.Add("@EmpGender", employee.EmpGender);
                param.Add("@EmpAddress", employee.EmpAddress);
                param.Add("@EmpContactNo", employee.EmpContactNo);

                rowAffected = con.Execute("AddNewEmpDetails", param, commandType : CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }

        public int DeleteEmployee(int empId)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EmpId", empId); 
                rowAffected = con.Execute("DeleteEmpDetails", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }

        public List<Employee> GetAllEmployees()
        {
            using (IDbConnection con = connection)
            {
                String query = "select * from Employee";
                con.Open();
                var result = con.Query<Employee>(query);
                return result.ToList<Employee>();
            }
        }

        public Employee GetById(int ID)
        {
            using (IDbConnection con = connection)
            {
                String query = "select EmpId,EmpName,EmpAge,EmpGender,EmpAddress,EmpContactNo from Employee where EmpId=@EmpId";
                con.Open();
                var result = con.QueryFirst<Employee>(query,new { EmpId = ID});
                return result;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            int rowAffected = 0;
            using (IDbConnection con = connection)
            {
                con.Open();
                var param = new DynamicParameters();
                param.Add("@EmpId", employee.EmpId);
                param.Add("@EmpName", employee.EmpName);
                param.Add("@EmpAge", employee.EmpAge);
                param.Add("@EmpGender", employee.EmpGender);
                param.Add("@EmpAddress", employee.EmpAddress);
                param.Add("@EmpContactNo", employee.EmpContactNo);

                rowAffected = con.Execute("UpdateEmpDetails", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            return rowAffected;
        }
    }
}
