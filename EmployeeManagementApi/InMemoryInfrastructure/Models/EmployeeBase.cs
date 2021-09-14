using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementApi.InMemoryInfrastructure.Models
{
    public class EmployeeBase
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ManagerId { get; set; }
    }
}
