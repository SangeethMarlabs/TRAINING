namespace Domain.Models
{
    public class EmployeeProfessional : BaseEntity
    {
        public string EmpDesignation { get; set; }
        public string EmpCompany { get; set; }
        public int EmpSalary { get; set; }
        public string EmpExperience { get; set; }
        public Employee Employee { get; set; } // foreign key

    }
}
