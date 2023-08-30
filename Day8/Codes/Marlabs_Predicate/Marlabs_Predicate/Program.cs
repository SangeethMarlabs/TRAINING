using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> checkIsAppleModel = isApple;
            bool result = checkIsAppleModel("IPhone 6");

            if (result == true)
            {
                Console.WriteLine("this is IPhone");
            }
            else
            {
                Console.WriteLine("Wrong model");
            }
            Console.ReadLine();
        }

        public static bool isApple(string modelName)
        {
            if(modelName=="IPhone 6")
            {
                return true;
            }
            else if (modelName == "IPhone X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
