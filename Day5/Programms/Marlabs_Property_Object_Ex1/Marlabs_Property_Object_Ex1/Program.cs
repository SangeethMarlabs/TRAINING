using System;
namespace Marlabs_Property_Object_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent1 = new Student()
            {
                StudentId = 100,
                StudentName = "Sangeeth",
                StudentEmail = "sangeeth@gmail.com",
                StudentAddress = "Kerala",
                StudentMarks = 80
            };            
            
            Student objStudent2 = new Student()
            {
                StudentId = 101,
                StudentName = "Sreeshaila",
                StudentEmail = "sreeshaila@gmail.com",
                StudentAddress = "Bangalore",
                StudentMarks = 85
            };

            Student objStudent3 = new Student()
            {
                StudentId = 100,
                StudentName = "Neha",
                StudentEmail = "neha@gmail.com",
                StudentAddress = "Bangalore",
                StudentMarks = 90,
            };

            objStudent1.DisplayStudent(1);
            objStudent2.DisplayStudent(2);
            objStudent3.DisplayStudent(3);

            Console.ReadLine();
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public int StudentMarks { get; set; }
        public string StudentEmail { get; set; }

        public void DisplayStudent(int slno)
        {
            Console.WriteLine($"\n----------------Student : {slno}---------------" +
                $"\nStudent Id      : {StudentId}" +
                $"\nStudent Name    : {StudentName}" +
                $"\nStudent Address : {StudentAddress}" +
                $"\nStudent Marks   : {StudentMarks}" +
                $"\nStudent Email   : {StudentEmail}" +
                $"\n--------------------------------------");
        }
    }
}
