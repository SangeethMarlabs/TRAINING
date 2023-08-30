using Domain.Models;
using Infrastructure.Repository;

namespace Services
{
    public class EmployeeProfessionalRepository : IEmployeeProfessionalRepository
    {
        IGenericRepository<EmployeeProfessional> employeeProfessionalRepository;
        public EmployeeProfessionalRepository(IGenericRepository<EmployeeProfessional> _employeeProfessionalRepository)
        {
            this.employeeProfessionalRepository = _employeeProfessionalRepository;
        }
        public EmployeeProfessional GetEmployeeProfessional(long Id)
        {
            return employeeProfessionalRepository.GetT(Id);
        }
    }
}
