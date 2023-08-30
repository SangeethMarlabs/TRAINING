using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Interface_Ex1
{
    public interface IArithemeticOperations<T>
    {
        T Addition(T a, T b);
        T Subtraction(T a, T b);
        T Multiplication(T a, T b);
        T Division(T a, T b);
    }
}
