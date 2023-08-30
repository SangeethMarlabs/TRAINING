using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedContainer<int> objint1NamedContainer = new NamedContainer<int>(1, "Sangeeth");
            NamedContainer<int> objint2NamedContainer = new NamedContainer<int>(2, "Sreeshaila");
            NamedContainer<string> objint3NamedContainer = new NamedContainer<string>("Hi", "Neha");
            Console.ReadLine();
        }
    }
}
