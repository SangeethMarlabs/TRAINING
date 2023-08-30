using Marlabs_ViewMode1_Ex1.Models;

namespace Marlabs_ViewMode1_Ex1.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string PageHeader { get; set; }
        public string PageTitle { get; set; }
    }
}
