using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using View_Model.Models;

namespace View_Model.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageHeader { get; set; }
        public string PageTitle { get; set; }
 
    }
}