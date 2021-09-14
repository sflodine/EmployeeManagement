using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.InMemoryInfrastructure
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int customerId);
        Employee CreateEmployee(Employee customer);
        IList<EmployeeBase> GetEmployees();
        bool Exists(int employeeId);
        Employee GetEmployeeById(int employeeId);
        string CreateNewEmployee(string name, int managerId, bool isManager);
        void SetInactive(int employeeId);
        IList<EmployeeBase> GetInactiveManagers();
    }
}