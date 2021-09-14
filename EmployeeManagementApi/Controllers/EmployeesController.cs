using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;
using EmployeeManagementApi.InMemoryInfrastructure;
using EmployeeManagementApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet]
        public IEnumerable<EmployeeBase> Get()
        {
            return this._employeesService.GetAll();
        }

//        [Route("[action]/{employeeId}")]
        [Route("[action]")]
        [HttpGet]
        public Employee GetEmployeeById(int employeeId){
            return this._employeesService.GetEmployeeById(employeeId);
        }

        [Route("[action]")]
        [HttpGet]
        public string CreateEmployee(string name, int managerId, bool isManager){
            return this._employeesService.CreateEmployee(name, managerId, isManager);
        }

        [Route("[action]")]
        [HttpGet]
        public void SetInactive(int employeeId){
            this._employeesService.SetInactive(employeeId);
        }

        
        [Route("[action]")]
        [HttpGet]
        public void GetInactiveManagers(){
            this._employeesService.GetInactiveManagers();
        }

    }
}