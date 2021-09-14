using System.ComponentModel.DataAnnotations;
using System;

namespace EmployeeManagementApi.InMemoryInfrastructure.Models
{
    
    public class Employee : EmployeeBase
    {
        [Required]
        public bool IsManager { get; set; }

        [Required]
        public bool Active { get; set; }

        public DateTime HiredDate {get; set;}
    }
}
