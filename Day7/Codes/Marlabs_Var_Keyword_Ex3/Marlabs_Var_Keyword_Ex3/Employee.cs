using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Var_Keyword_Ex3
{
    public class Employee
    {
        public dynamic empId;
        public dynamic empName = "Sangeeth";

        public void EmpInfo()
        {
            empId = 90;
            Console.WriteLine($"Emp Id : {empId}");
        }
        public dynamic Empinformation()
        {
            return empName;
        }

    }
}
