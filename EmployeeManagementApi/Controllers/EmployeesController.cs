using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;
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
        public IEnumerable<Employee> Get()
        {
            return this._employeesService.GetAll();
        }
    }
}