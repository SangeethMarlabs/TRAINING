using System;
using System.Collections.Generic;
using System.Linq; 

namespace Marlabs_JoinOperator_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList1 = new List<string>()
            {
                "Joe",
                "Joy",
                "Praveen"
            };     
            
            List<string> strList2 = new List<string>()
            {
                "Joe",
                "Joy",
                "Praveen",
                "Pooja",
                "Venkat",
            };

            var innerJoinResult = strList1.Join(//outer sequence
                strList2,//inner sequence
                str1=> str1,//outer key selecter
                str2=> str2,//inner key selecter
                (str1,str2) => str1);

            foreach(var str in innerJoinResult)
            {
                Console.WriteLine("{0}", str);
            }
            Console.ReadLine();
        }
    }
}
