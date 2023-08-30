using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Functions_Assign_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Adding Integers---------------");
            Operations objOperations = new Operations();
            int sum = objOperations.Add<int>(10, 20);
            Console.WriteLine($"The addition would be :: {sum}");

            Console.WriteLine("--------------Adding Float---------------");
            float floatSum = objOperations.Add<float>(100.20f, 2000.10f);
            Console.WriteLine($"The float addition would be :: {floatSum}");            
            
            Console.WriteLine("--------------Adding Decimal---------------");
            decimal decimalSum = objOperations.Add<decimal>(100.20m, 2000.10m);
            Console.WriteLine($"The float addition would be :: {decimalSum}");    
            
            Console.WriteLine("--------------Adding Double---------------");
            double doubleSum = objOperations.Add<double>(100.20d, 2000.10d);
            Console.WriteLine($"The double addition would be :: {doubleSum}");            
            
            Console.WriteLine("--------------Adding String---------------");
            string strConcat = objOperations.Add<string>("Sangeeth"," Sudhakaran");
            Console.WriteLine($"The string addition would be :: {strConcat}");


            Console.WriteLine("--------------Substract Integers---------------");
            int sub = objOperations.Sub<int>(100, 20);
            Console.WriteLine($"The substract would be :: {sub}");

            Console.WriteLine("--------------Substract float---------------");
            float floatSub = objOperations.Sub<float>(100.25f, 20.35f);
            Console.WriteLine($"The substract would be :: {floatSub}");

            Console.WriteLine("--------------Multiply Integers---------------");




            Console.ReadLine();


        }
    }
}
