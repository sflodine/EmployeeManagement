using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.InMemoryInfrastructure
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int customerId);
        Employee CreateEmployee(Employee customer);
        IList<Employee> GetEmployees();
        bool Exists(int employeeId);
    }
}