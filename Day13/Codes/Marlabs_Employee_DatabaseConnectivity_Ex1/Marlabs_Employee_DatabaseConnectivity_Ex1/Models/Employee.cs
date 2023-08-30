using System.ComponentModel.DataAnnotations;


namespace Marlabs_Employee_DatabaseConnectivity_Ex1.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpDept { get; set; }
        public string EmpSal { get; set; }
    }
}