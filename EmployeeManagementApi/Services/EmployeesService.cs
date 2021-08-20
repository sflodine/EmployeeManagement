using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IList<Employee> GetAll()
        {
            return _employeeRepository.GetEmployees();
        }
    }
}
