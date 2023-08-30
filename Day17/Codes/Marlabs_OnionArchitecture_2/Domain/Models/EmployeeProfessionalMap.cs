using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Models
{
    class EmployeeProfessionalMap
    {
        public EmployeeProfessionalMap(EntityTypeBuilder<EmployeeProfessional> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.EmpDesignation).IsRequired();
            entityTypeBuilder.Property(t => t.EmpExperience).IsRequired();
            entityTypeBuilder.Property(t => t.EmpSalary).IsRequired();
            entityTypeBuilder.Property(t => t.EmpCompany).IsRequired();
        }
    }
}
