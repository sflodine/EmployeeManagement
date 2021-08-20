using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApi.InMemoryInfrastructure.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsManager { get; set; }

        [Required]
        public bool Active { get; set; }

        public int ManagerId { get; set; }
    }
}
