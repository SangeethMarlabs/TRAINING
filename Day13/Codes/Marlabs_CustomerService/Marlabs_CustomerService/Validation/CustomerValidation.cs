using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_CustomerService.Models;
using FluentValidation;

namespace Marlabs_CustomerService.Validation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c => c.CustomerId).NotNull();
            RuleFor(c => c.CustomerName).Length(0, 10).WithMessage("Customer Name should not be exceed than 10 characters");
            RuleFor(c => c.CustomerName).NotNull().WithMessage("Customer Name should not be empty");
            RuleFor(c => c.CustomerEmail).EmailAddress().WithMessage("Customer E=email should be in proper format");
            RuleFor(c => c.CustomerAge).InclusiveBetween(10,50).WithMessage("Customer age must be between 10 and 50");
            RuleFor(c => c.CustomerPhone).MinimumLength(10).MaximumLength(15).WithMessage("Customer phone number length must be between 10 and 50");

        }
    }
}
