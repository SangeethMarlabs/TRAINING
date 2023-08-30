using Domain.Models;
using Infrastructure.Repository;

namespace Services
{
    public class EmployeeQualificationRepository : IEmployeeQualificationRepository
    {
        IGenericRepository<EmployeeQualification> employeeQualificationRepository;
        public EmployeeQualificationRepository(IGenericRepository<EmployeeQualification> _employeeQualificationRepository)
        {
            this.employeeQualificationRepository = _employeeQualificationRepository;
        }
        public EmployeeQualification GetEmployeeQualification(long Id)
        {
            return employeeQualificationRepository.GetT(Id);
        }
    }
}
