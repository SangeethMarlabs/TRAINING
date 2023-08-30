using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Func_Delegate_Ex3
{
    public class AreaOperations
    {
        public int AreaSquare(int side)
        {
            return side * side;
        }
        public int AreaRectangle(int length, int width)
        {
            return length * width;
        }
        public int AreaTrinagle(int length,int height)
        {
            return length * height;
        }
        public double AreaCircle(int radious)
        {
            return (radious * radious) * 3.14;
        }

    }
}
