using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Hashset_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstNames = new HashSet<string>()
            {
               "Sangeeth",
               "Sreeshaila",
               "Neha",
               "Pooja",
               "Sai",
               "Shahnavas",
                "Pooja",
               "Sai",
               "Shahnavas"
            };
             

            foreach (var str in lstNames)
            {
                Console.WriteLine($"The HashSet list name would be :: {str}");
            }
            Console.ReadLine();
        }

    }
}
