using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Int--------");
            MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
            int val = integerGenericClass.Genericmethod(40);
            Console.WriteLine(val);

            Console.WriteLine("-----------String--------");
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Sangeeth");
            string str = stringGenericClass.Genericmethod("Sreeshaila");
            Console.WriteLine(str);

            Console.WriteLine("-----------Default generic constructor invoked--------");
            Console.WriteLine("-----------String--------");
            MyGenericClass<string> stringGenericClassDefaultConstructor = new MyGenericClass<string>();
            stringGenericClassDefaultConstructor.GenericProperty = "Neha";
            string strDefaultConstructor = stringGenericClassDefaultConstructor.GenericProperty;
            Console.WriteLine(strDefaultConstructor);

            Console.WriteLine("-----------Default generic constructor invoked property--------");
            Console.WriteLine("-----------String--------");
            MyGenericClass<string> stringGenericClassProperty = new MyGenericClass<string>();
            stringGenericClassProperty.GenericProperty = "Sai";
            string strProperty = stringGenericClassProperty.GenericProperty;
            Console.WriteLine(strProperty);
            Console.ReadLine();
        }
    }
}
