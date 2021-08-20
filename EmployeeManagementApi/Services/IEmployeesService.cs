using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.Services
{
    public interface IEmployeesService
    {
        IList<Employee> GetAll();
    }
}