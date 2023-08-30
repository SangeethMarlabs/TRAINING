using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Dictionary_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Dict = new Dictionary<int, string>()
            {
                {1,"Sangeeth"},
                {2,"Sreeshaila"},
                {3,"Neha"},
                {4,"Pooja"},
                {5,"Venkat"},
                {6,"Praveena"},
                {7,"Anjum"},
                {8,"Venkat"},
                {9,"Venkat"},
                {10,"Venkat"},
                {11,"Venkat"},
            };

            foreach(KeyValuePair<int, string> kvp in Dict)
            {
                Console.WriteLine($"Key{kvp.Key} | Key{kvp.Value}  ");
            }

            Dict.Remove(7);
            Dict.Remove(8);

            foreach (KeyValuePair<int, string> kvp in Dict)
            {
                Console.WriteLine($"Key{kvp.Key} | Key{kvp.Value}  ");
            }

            if (Dict.ContainsKey(2))
            {
                Console.WriteLine("Key found");
            }
            else 
            {
                Console.WriteLine("Key not found");
            }
        }
    }
}
