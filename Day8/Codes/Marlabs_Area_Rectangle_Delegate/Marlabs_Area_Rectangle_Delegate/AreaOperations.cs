using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Area_Rectangle_Delegate
{
    class AreaOperations
    {
        public T AreaRectangle<T>(T length, T width)
        {
            return (dynamic)length * width;
        }
        public T AreaSquare<T>(T side)
        {
            return (dynamic)side * side;
        }
        public T AreaCircle<T>(T radious)
        {
            return (dynamic)radious * radious*3.14;
        }
    }
}
