using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float EmpSal { get; set; }
        public string EmpGender { get; set; }
        public string EmpDept { get; set; }
        public int AddressId { get; set; }
    }
}