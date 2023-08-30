using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Interface_Ex1
{
    public class ArithemeticOperations<T> : IArithemeticOperations<T>
    {
 
        public T Addition(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        } 
        public T Subtraction(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        } 
        public T Multiplication(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        } 
        public T Division(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
         
    }
}
