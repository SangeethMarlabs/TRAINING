using System;
namespace Marlabs_DependancyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer objComputer = new Computer(new Processor(10));
            //Processor objProcessor = new Processor();
            Console.ReadLine();
        }
    }

    public class Computer
    {
        Processor processor;
        public Computer(Processor _processor)
        {
            this.processor = _processor;
            Console.WriteLine("Computer class called");
        }
    }
    public class Processor
    {
        public Processor(int speed)
        {
            Console.WriteLine("Speed-" + speed);
            Console.WriteLine("Processor class called");
        }
    }
}
