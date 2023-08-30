using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_ViewMode1_Ex2.Models;

namespace Marlabs_ViewMode1_Ex2.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageHeader { get; set; }
        public string PageTitle { get; set; }

    }
}
