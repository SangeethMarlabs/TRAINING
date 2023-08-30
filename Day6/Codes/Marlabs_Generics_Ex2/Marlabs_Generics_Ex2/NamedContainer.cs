using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Ex2
{
    public class NamedContainer<T>//T generics
    {
        public T Item { get; }
        public string Name { get; }
        
        public NamedContainer(T item, string name)
        {
            Item = item;
            Name = name;
            Console.WriteLine($"Item : {Item} | Name : {Name}");
        }
    }
}
