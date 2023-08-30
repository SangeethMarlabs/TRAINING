using Marlabs_CustomerService.EntityFramework;
using Marlabs_CustomerService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_CustomerService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext customerDbContext;

        public CustomerRepository(CustomerDbContext _customerDbContext)
        {
            this.customerDbContext = _customerDbContext;
        }

        public int CreateCustomer(Customer customer)
        {
            this.customerDbContext.Add(customer);
            return this.customerDbContext.SaveChanges();
        }

        public int DeleteCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            customerDbContext.Customers.Remove(customer);
            return this.customerDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customerDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int id)
        {
            return customerDbContext.Customers.SingleOrDefault(t => t.CustomerId == id);
        }

        public int UpdateCustomer(Customer customer)
        {
           if(customer == null)
            {
                throw new ArgumentNullException("Entity mising");
            }
            customerDbContext.Customers.Update(customer);
            return customerDbContext.SaveChanges();
        }
    }
}
