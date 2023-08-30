using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_Marlabs_Generics_Functions_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.show<int>(60);
            objParent.show<string>("Parent Called");
            objParent.show(true);
            objParent.show<int>(38);
            objParent.show("A");
            Console.ReadLine();
        }
    }
}
