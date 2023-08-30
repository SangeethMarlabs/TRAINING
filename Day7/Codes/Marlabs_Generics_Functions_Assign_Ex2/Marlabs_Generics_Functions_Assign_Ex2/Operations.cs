using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Functions_Assign_Ex2
{
    class Operations
    {
        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public T Sub<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        public T Mul<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

        public T Div<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
