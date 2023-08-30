namespace Domain.Models
{
    public class Employee : BaseEntity
    {
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpEmail { get; set; }
        public string EmpContact { get; set; }
        public EmployeeProfessional EmployeeProfessional { get; set; } // foreign key
        public EmployeeQualification EmployeeQualification { get; set; } // foreign key
    }
}
