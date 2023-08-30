using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics
{
    public class Employee<T>//<T Denotes generics>
    {
        public T value { get; set; }
    }

}
