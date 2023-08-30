using Marlabs_Dapper_Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_Dapper_Customer.Repository
{
    public interface ICustomerRepository
    {
        Customer GetById(int custId);
        int AddCustomer(Customer Customer);
        int UpdateCustomer(Customer Customer);
        int DeleteCustomer(int custId);
        List<Customer> GetAllCustomers();
    }
}
