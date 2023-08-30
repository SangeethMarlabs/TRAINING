using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Hashset_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstNames = new HashSet<string>();
            lstNames.Add("Sangeeth");
            lstNames.Add("Sreeshaila");
            lstNames.Add("Neaha");
            lstNames.Add("Sai");
            lstNames.Add("Shahanavas");
            lstNames.Add("Pooja");
            lstNames.Add("Praveena");
            lstNames.Add("Anjum");

            foreach (var str in lstNames)
            {
                Console.WriteLine($"The HashSet list name would be :: {str}");
            }
            Console.ReadLine();
        }
    }
}
