using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marlabs_SingleRecordViewDataEmployee.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress1 { get; set; }
        public string EmpAddress2 { get; set; }
        public string EmpContact { get; set; }
        public int EmpSal { get; set; }
        public string EmpEmail { get; set; }

    }
}