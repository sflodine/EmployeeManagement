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

        public IList<EmployeeBase> GetAll()
        {
            return _employeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int employeeId){
            return _employeeRepository.GetEmployeeById(employeeId);
        }

        public string CreateEmployee(string name, int managerId, bool isManager){
            return _employeeRepository.CreateNewEmployee(name, managerId, isManager);
        }

        public void SetInactive(int employeeId){
            _employeeRepository.SetInactive(employeeId);
        }

        public IList<EmployeeBase> GetInactiveManagers(){
            return _employeeRepository.GetInactiveManagers();
        }
    }
}
