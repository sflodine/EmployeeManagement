using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.InMemoryInfrastructure
{
    public interface IDataContext
    {
        IList<Employee> Employees { get; }
    }
}
