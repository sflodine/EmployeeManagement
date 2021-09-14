using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;
using EmployeeManagementApi.InMemoryInfrastructure;

namespace EmployeeManagementApi.Services
{
    public interface IEmployeesService
    {
        IList<EmployeeBase> GetAll();
        Employee GetEmployeeById(int employeeId);
        string CreateEmployee(string name, int managerId, bool isManager);
        void SetInactive(int employeeId);
        IList<EmployeeBase> GetInactiveManagers();
    }
}