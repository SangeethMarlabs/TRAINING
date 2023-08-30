using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Models
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.EmpName).IsRequired();
            entityTypeBuilder.Property(t => t.EmpName).HasMaxLength(50);
            entityTypeBuilder.Property(t => t.EmpAddress).IsRequired();
            entityTypeBuilder.Property(t => t.EmpEmail).IsRequired();
            entityTypeBuilder.Property(t => t.EmpContact).IsRequired();

            entityTypeBuilder.HasOne(t => t.EmployeeProfessional).WithOne(e => e.Employee).HasForeignKey<EmployeeProfessional>(x => x.Id);
            entityTypeBuilder.HasOne(t => t.EmployeeQualification).WithOne(e => e.Employee).HasForeignKey<EmployeeQualification>(x => x.Id);
        }
    }
}
