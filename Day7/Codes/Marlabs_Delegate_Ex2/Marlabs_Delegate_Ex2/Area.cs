using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Delegate_Ex2
{
    public class Area
    {
        public int AreaRectangle(int length,int width)
        {
            return length * width;
        }
        public int AreaSquare(int side)
        {
            return side * side; 
        }
        public double AreaCircle(double radious)
        {
            return Convert.ToDouble(3.14) * radious;
        }
    }
}
