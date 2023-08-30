namespace Domain.Models
{
    public class EmployeeQualification : BaseEntity
    {
        public string EmpCourse { get; set; }
        public string EmpDegree { get; set; }
        public string EmpCollege { get; set; }
        public Employee Employee { get; set; } // foreign key
    }
}
