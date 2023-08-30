using Domain.Models;
using Infrastructure.Repository;
namespace Services
{
    public interface IEmployeeQualificationRepository
    {
        EmployeeQualification GetEmployeeQualification(long Id);
    }
}
