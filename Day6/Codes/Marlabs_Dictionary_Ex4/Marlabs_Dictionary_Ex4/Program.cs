using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Dictionary_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit, key;
            string value;
            Console.WriteLine("--------------Dictionary--------------");
            Dictionary<int, string> Dict = new Dictionary<int, string>();

        Start:
            Console.WriteLine("Enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the {limit} keys and {limit} values");

            for(int i =1; i <= limit; i++)
            {
                Console.WriteLine("Enter the key");
                key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value");
                value =  (Console.ReadLine());
                Dict.Add(key, value);
            }
            foreach(KeyValuePair<int,string> kvp in Dict)
            {
                Console.WriteLine($"key-{kvp.Key} value-{}");
            }
            goto Start;
        }
    }
}
