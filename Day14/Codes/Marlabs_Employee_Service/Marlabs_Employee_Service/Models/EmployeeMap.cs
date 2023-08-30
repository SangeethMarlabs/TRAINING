using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marlabs_Employee_Service.Models
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(emp => emp.EmployeeId);
            entityTypeBuilder.Property(emp => emp.EmployeeName).IsRequired();
            entityTypeBuilder.Property(emp => emp.EmployeeName).HasMaxLength(50);
            entityTypeBuilder.Property(emp => emp.EmployeeEmail).IsRequired();
            entityTypeBuilder.Property(emp => emp.EmployeePhone).IsRequired();
        }
    }
}
