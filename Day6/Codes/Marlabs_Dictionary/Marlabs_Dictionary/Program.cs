using System;
using System.Collections.Generic;

namespace Marlabs_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Sangeeth");
            dictionary.Add(2, "Sreeshaila");
            dictionary.Add(3, "Neha");
            dictionary.Add(4, "Venkat");
            dictionary.Add(5, "Shahnavas");
            dictionary.Add(6, "Pooja");
            dictionary.Add(7, "Anjum");

            foreach(KeyValuePair<int,string> kvp in dictionary1)
            {
                Console.WriteLine($"Key - {kvp.Key} | Value - {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
