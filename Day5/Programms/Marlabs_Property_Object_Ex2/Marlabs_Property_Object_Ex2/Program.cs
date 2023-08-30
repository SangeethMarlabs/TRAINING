using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Property_Object_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson1 = new Person()
            {
                PersonId=101,
                PersonName="Sangeeth",
                PersonAddress ="Kerala",
                PersonEmail="sangeeth@gmail.com"
            };
            
            Person objPerson2 = new Person()
            {
                PersonId = 102,
                PersonName = "Neha",
                PersonAddress = "Bangalore",
                PersonEmail = "neha@gmail.com"
            };

            Person objPerson3 = new Person()
            {
                PersonId = 103,
                PersonName = "Sreeshaila",
                PersonAddress = "Bangalore",
                PersonEmail = "sreeshaila@gmail.com"
            };

            objPerson1.DisplayPerson(1);
            objPerson2.DisplayPerson(2);
            objPerson3.DisplayPerson(3);

            Console.ReadLine();
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonAddress { get; set; }
        public string PersonEmail { get; set; }

        public void DisplayPerson(int slno)
        {
            Console.WriteLine($"-------------Person : {slno}------------" +
                $"\nPerson Id : {PersonId}" +
                $"\nPerson Name : {PersonName}" +
                $"\nPerson Address : {PersonAddress}" +
                $"\nPerson Email : {PersonEmail}" +
                $"\n-----------------------------------");
        }
    }
}
