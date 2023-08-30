using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder oModelBuilder)
        {
            //from this function, we can do association for user to user map and 
            new EmployeeMap(oModelBuilder.Entity<Employee>());
            new EmployeeProfessionalMap(oModelBuilder.Entity<EmployeeProfessional>());
            new EmployeeQualificationMap(oModelBuilder.Entity<EmployeeQualification>());
        }
    }
}
