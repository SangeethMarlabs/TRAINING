using Domain.Models;
namespace Services
{
    public interface IEmployeeProfessionalRepository
    {
        EmployeeProfessional GetEmployeeProfessional(long Id);
    }
}
