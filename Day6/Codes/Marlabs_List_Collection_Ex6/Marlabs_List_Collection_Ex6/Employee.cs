using System;
using System.Collections.Generic;

namespace Marlabs_List_Collection_Ex6
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpContacts { get; set; }
        public string EmpEmail { get; set; }
        public List<Department> lstDept { get; set; }
    }
}
