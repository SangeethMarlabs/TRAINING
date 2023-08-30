using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_ViewMode1_Ex3.Models;

namespace Marlabs_ViewMode1_Ex3.ViewModel
{
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public StudentDetail StudentDetail { get; set; }
        public string StudData1 { get; set; }
        public string StudData2 { get; set; }
    }
}
