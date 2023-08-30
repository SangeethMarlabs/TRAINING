using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_List_Collections_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> lstNames = new List<string> { 
                 "Sangeeth","Neha","Sai","Rakesh","Sreeshaila","Shahanavas"
             };

            foreach(string str in lstNames)
            {
                Console.WriteLine($"List names would be :: {str}");
            }
            Console.ReadLine();
        }
    }
}
