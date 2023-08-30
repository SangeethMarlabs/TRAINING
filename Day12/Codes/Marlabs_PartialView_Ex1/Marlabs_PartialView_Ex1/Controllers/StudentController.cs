using Marlabs_PartialView_Ex1.Models; 
using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 

namespace Marlabs_PartialView_Ex1.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult GetStudentDetails()
        {
            List<Student> objListStudents = new List<Student>()
            {
               
                new Student()
                {
                    StudId=100,StudName="Sangeeth",StudAddress="Kerala",StudEmail="sangeeth@gmail.com",StudPhone="9633337115"
                },               
                new Student()
                {
                    StudId=101,StudName="Sreeshaila",StudAddress="bangalore",StudEmail="sreeshaila@gmail.com",StudPhone="8956231254"
                },               
                new Student()
                {
                    StudId=102,StudName="Neha",StudAddress="Bangalore",StudEmail="neeha@gmail.com",StudPhone="8945781223"
                },               
                new Student()
                {
                    StudId=103,StudName="Venkat",StudAddress="Bangalore",StudEmail="venkat@gmail.com",StudPhone="9226594815"
                },               
                new Student()
                {
                    StudId=104,StudName="Shahanavas",StudAddress="TamilNadu",StudEmail="shahanavas@gmail.com",StudPhone="9678549562"
                }
            };
            return View(objListStudents);
        }
    }
}
