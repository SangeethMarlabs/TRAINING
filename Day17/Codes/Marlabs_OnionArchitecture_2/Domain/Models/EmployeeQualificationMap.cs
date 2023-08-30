using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Models
{
    class EmployeeQualificationMap
    {
        public EmployeeQualificationMap(EntityTypeBuilder<EmployeeQualification> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.EmpCourse).IsRequired();
            entityTypeBuilder.Property(t => t.EmpCollege).IsRequired();
            entityTypeBuilder.Property(t => t.EmpDegree).IsRequired();
        }
    }
}
