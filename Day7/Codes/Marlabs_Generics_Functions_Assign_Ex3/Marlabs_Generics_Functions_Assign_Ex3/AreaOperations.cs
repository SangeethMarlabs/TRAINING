using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Functions_Assign_Ex3
{
    class AreaOperations
    {
        public T AreaRectangle<T>(T length, T width)
        {
            dynamic x = length;
            dynamic y = width;
            return x * y;
        }
        public T AreaCircle<T>(T radious, T pie)
        {
            dynamic x = radious; 
            dynamic y = pie; 
            return y * x;
        }

        public T AreaSquare<T>(T side)
        {
            dynamic x = side;
            return x * x;
        }
    }
}
