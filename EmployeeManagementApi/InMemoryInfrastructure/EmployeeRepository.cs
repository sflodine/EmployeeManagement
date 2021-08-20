using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.InMemoryInfrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDataContext _dataContext;

        public EmployeeRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Employee GetEmployee(int customerId)
        {
            return _dataContext.Employees.SingleOrDefault(x => x.Id == customerId);
        }

        public Employee CreateEmployee(Employee customer)
        {
            customer.Id = _dataContext.Employees.DefaultIfEmpty(new Employee()).Max(x => x.Id) + 1;
            _dataContext.Employees.Add(customer);

            return customer;
        }

        public IList<Employee> GetEmployees()
        {
            return _dataContext.Employees;
        }

        public bool Exists(int employeeId)
        {
            return _dataContext.Employees.Any(x => x.Id == employeeId);

        }
    }
}
