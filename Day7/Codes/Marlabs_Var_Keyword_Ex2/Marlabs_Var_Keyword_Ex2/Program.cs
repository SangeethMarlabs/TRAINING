using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Var_Keyword_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic i = 90;
            Console.WriteLine(i);
            i = "Sangeeth";
            Console.WriteLine(i);
            i = false;
            Console.WriteLine(i);
            i = 99.099f;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
