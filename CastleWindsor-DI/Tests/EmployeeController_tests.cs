using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CastleWindsor_DI.Controllers.Employee;
using CastleWindsor_DI.Domain;
using CastleWindsor_DI.Services;
using Moq;
using NUnit.Framework;

namespace CastleWindsor_DI.Tests
{
    [TestFixture]
    public class EmployeeController_tests
    {
        [Test]
        [ExpectedException(typeof(Exception))]
        public void when_getemployees_returns_empty_then_exception_thrown()
        {
            // arrange
            var employeeService = new Mock<IEmployeeService>();
            employeeService.Setup(x => x.GetEmployees()).Returns(new List<Employee>());
            var controller = new EmployeeController(employeeService.Object);

            // act
            controller.Index();
        }
    }
}