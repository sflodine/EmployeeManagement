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

        public IList<EmployeeBase> GetEmployees()
        {
            return MapToEmployeeBase(_dataContext.Employees);
        }

        public bool Exists(int employeeId)
        {
            return _dataContext.Employees.Any(x => x.Id == employeeId);

        }

        private IList<EmployeeBase> MapToEmployeeBase(IList<Employee> employees){
            return employees.OrderBy(em=>em.HiredDate).Select(e => new EmployeeBase(){Id=e.Id,Name=e.Name,ManagerId=e.ManagerId}).ToList<EmployeeBase>();            
        }

        public Employee GetEmployeeById(int employeeId){
            return _dataContext.Employees.Where(e=>e.Id==employeeId).First();
        }

        public string CreateNewEmployee(string name, int managerId, bool isManager){
            if (!_dataContext.Employees.Any(x => x.Id == managerId && x.IsManager)) return "Employee must report to a valid manager";
            _dataContext.Employees.Add(new Employee(){ Name=name, ManagerId = managerId, IsManager=isManager, Id=GetNextAvailableId(), Active=true});
            return "Successful";
        }

        private int GetNextAvailableId(){
            return _dataContext.Employees.DefaultIfEmpty(new Employee()).Max(x => x.Id) + 1;

        }

        public void SetInactive(int employeeId){
            var employee = _dataContext.Employees.FirstOrDefault(e => e.Id == employeeId);
            employee.Active = false;
        }

        public IList<EmployeeBase> GetInactiveManagers(){
            var employees = _dataContext.Employees.Where(e=>!e.Active && e.IsManager).ToList<Employee>();
            return MapToEmployeeBase(employees);
        }
    }
}
