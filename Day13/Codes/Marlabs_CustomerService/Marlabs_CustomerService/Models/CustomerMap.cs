using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marlabs_CustomerService.Models
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(cust => cust.CustomerId);
            entityTypeBuilder.Property(cust => cust.CustomerId).IsRequired();
            entityTypeBuilder.Property(cust => cust.CustomerName).IsRequired();
            entityTypeBuilder.Property(cust => cust.CustomerEmail).IsRequired();
            entityTypeBuilder.Property(cust => cust.CustomerPhone).IsRequired();
            entityTypeBuilder.Property(cust => cust.CustomerName).HasMaxLength(50);
        }
    }
}
