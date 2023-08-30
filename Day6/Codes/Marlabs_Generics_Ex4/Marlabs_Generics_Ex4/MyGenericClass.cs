using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Ex4
{
    public class MyGenericClass<T>
    {
        //Generic variables
        private T genericMemberVariables;

        //Generic Parameterized constructor
        public MyGenericClass(T value)
        {
            Console.WriteLine("Parameterized generic constructor invoked");
            genericMemberVariables = value;
        }

        //Normal constructor
        public MyGenericClass()
        {
            Console.WriteLine("Default generic constructor invoked");
        }

         //Generic property
         public T GenericProperty { get; set; }

        //Generic method
        public T Genericmethod(T GenericParameter)
        {
            Console.WriteLine("Parameter type {0}, value : {1}",typeof(T),GenericParameter);
            Console.WriteLine("Return type {0} value {1}",typeof(T),genericMemberVariables);
            return genericMemberVariables;
        }
    }
}
