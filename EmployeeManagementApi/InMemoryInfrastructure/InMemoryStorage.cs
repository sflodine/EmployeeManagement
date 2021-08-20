using System.Collections.Generic;
using EmployeeManagementApi.InMemoryInfrastructure.Models;

namespace EmployeeManagementApi.InMemoryInfrastructure
{
    /// <summary>
    /// The purpose of this class is to provide a way to access and store data without a database.
    /// </summary>
    public class InMemoryStorage : IDataContext
    {
        static InMemoryStorage() { }

        private InMemoryStorage() { }

        public static InMemoryStorage Instance { get; private set; } = new InMemoryStorage();

        public IList<Employee> Employees { get; } = LoadEmployees();

        private static IList<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, IsManager = false, ManagerId = 0, Name = "John S", Active = true },
                new Employee { Id = 2, IsManager = false, ManagerId = 1, Name = "Jacob C", Active = true },
                new Employee { Id = 3, IsManager = false, ManagerId = 1, Name = "Justin A", Active = true },
                new Employee { Id = 4, IsManager = false, ManagerId = 1, Name = "Jessica R", Active = true },
                new Employee { Id = 5, IsManager = false, ManagerId = 1, Name = "Jane G", Active = false },
                new Employee { Id = 6, IsManager = false, ManagerId = 1, Name = "James W", Active = true }
            };
        }

        public static void Reset()
        {
            Instance = new InMemoryStorage();
        }
    }
}
