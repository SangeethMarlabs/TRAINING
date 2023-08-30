using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Lookup_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployee = new List<Employee>()
            {
                new Employee(){Name="Sangeeth",Department="IT",Country="India"},
                new Employee(){Name = "Diksha", Department = "Finance", Country="Denmark"},
                new Employee(){Name = "Raksha", Department = "HR", Country="Italy"},
                new Employee(){Name = "Daksh", Department = "HR", Country="UK"},
                new Employee(){Name = "Dia", Department = "IT", Country="USA"},
                new Employee(){Name = "Ria", Department = "IT", Country="Russia"},
            };

            var Emp = lstEmployee.ToLookup(x => x.Department);

            Console.WriteLine("Grouping Employees by Department");
            Console.WriteLine("+++++++++++++++++++++++++++++++++");

            foreach (var KeyValuePair in Emp)
            {
                Console.WriteLine(KeyValuePair.Key);
                foreach (var item in Emp[KeyValuePair.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
                }
            }



            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
}
