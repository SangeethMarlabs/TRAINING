using Marlabs_CustomerService.Models;
using System.Collections.Generic;

namespace Marlabs_CustomerService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer SearchCustomer(int id);
        int UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
        int DeleteCustomer(Customer customer);
    }
}
