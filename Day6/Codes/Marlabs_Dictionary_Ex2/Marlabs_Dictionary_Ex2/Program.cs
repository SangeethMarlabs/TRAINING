using System;
using System.Collections.Generic;

namespace Marlabs_Dictionary_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1,"Sangeeth"},{2,"Sreeshaila"},{3,"Neha"},
                {4,"Praveena"},{5,"Pooja"},{6,"Venkat"}
            };

            foreach(KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"Key-{kvp.Key} | Value-{kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
