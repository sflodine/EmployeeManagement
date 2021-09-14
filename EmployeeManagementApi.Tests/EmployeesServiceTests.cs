using EmployeeManagementApi.InMemoryInfrastructure;
using EmployeeManagementApi.Services;
using NSubstitute;
using NUnit.Framework;

namespace EmployeeManagementApi.Tests
{
    [TestFixture]
    public class EmployeesServiceTests
    {

        [Test]
        public void GetAll_WhenCalled_CallsGetAllEmployees()
        {
            var repository = Substitute.For<IEmployeeRepository>();
            var service = new EmployeesService(repository);

            service.GetAll();

            repository.Received().GetEmployees();
        }

        [Test]
        public void GetAll_WhenCalled_CallsGetInactiveManagers(){
            var repository = Substitute.For<IEmployeeRepository>();
            var service = new EmployeesService(repository);

            service.GetAll();

            repository.Received().GetInactiveManagers();
        }
    }
}
