using Microsoft.AspNetCore.Mvc;
using Marlabs_ViewMode1_Ex3.Models;
using Marlabs_ViewMode1_Ex3.ViewModel;
using System.Collections.Generic;

namespace Marlabs_ViewMode1_Ex3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetStudentDetails()
        {
            List<StudentDetailsViewModel> objLst = new List<StudentDetailsViewModel>();
            
            Student objStudent1 = new Student()
            {
                StudId=101,StudName="Sangeeth",StudAddress1="India",StudAddress2="Kerala",StudEmail="sangeeth@gmail.com",StudPhone="9633337115",StudDetailId=1001
            };
            StudentDetail objStudentD1 = new StudentDetail(){
                StudDetailId=1001,StudSubject="Sub1",StudClass="BCA",StudMark="80%"
            };
            StudentDetailsViewModel objStudentDVM1 = new StudentDetailsViewModel()
            {
                Student = objStudent1,StudentDetail=objStudentD1,StudData1="5",StudData2="3"
            };            
            
            //Student2
            Student objStudent2 = new Student()
            {
                StudId=101,StudName="Sreeshaila",StudAddress1="India",StudAddress2="bangalore",StudEmail="sreeshaila@gmail.com",StudPhone="989565465468",StudDetailId=1002
            };
            StudentDetail objStudentD2 = new StudentDetail(){
                StudDetailId=1002,StudSubject="Sub2",StudClass="MCA",StudMark="82%"
            };
            StudentDetailsViewModel objStudentDVM2 = new StudentDetailsViewModel()
            {
                Student = objStudent2,StudentDetail=objStudentD2,StudData1="5",StudData2="3"
            };

                        
            //Student3
            Student objStudent3 = new Student()
            {
                StudId=101,StudName="Neha",StudAddress1="India",StudAddress2="bangalore",StudEmail="neha@gmail.com",StudPhone="84849865123",StudDetailId=1003
            };
            StudentDetail objStudentD3 = new StudentDetail(){
                StudDetailId=1003,StudSubject="Sub3",StudClass="MCA",StudMark="85%"
            };
            StudentDetailsViewModel objStudentDVM3 = new StudentDetailsViewModel()
            {
                Student = objStudent3,StudentDetail=objStudentD3,StudData1="5",StudData2="3"
            };

            objLst.Add(objStudentDVM1);
            objLst.Add(objStudentDVM2);
            objLst.Add(objStudentDVM3);

            return View(objLst);
        }
    }
}
