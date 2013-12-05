using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ControllerKata.Controllers;
using ControllerKata.Domain;
using ControllerKata.Repository;
using NUnit.Framework;

namespace ControllerKata.Tests
{
    [TestFixture]
    public class MyControllerTests
    {
        [Test]
        // test controller action returns correct type
        public void IndexMethod_NoParameters_ReturnsViewResultMessageWelcome()
        {
            var controller = new MyController();
            var result = controller.Index() as ViewResult;

            Assert.IsInstanceOf<ViewResult>(result);
        
        }
        [Test]
        public void GetCustomers_returns_correct_model()
        {
            //mock repo
            var repo = new Moq.Mock<ICustomerRepository>();
            repo.Setup(x => x.GetAll()).Returns(new List<Customer>());

            var controller = new MyController(repo.Object);
            var result = controller.GetCustomers() as ViewResult;

            Assert.IsInstanceOf<List<Customer>>(result.ViewData.Model);
        }

        [Test]
        public void Redirect_has_correct_routevalues()
        {
            var mockRepo = new Moq.Mock<ICustomerRepository>();
            var controller = new MyController(mockRepo.Object);
            var result = controller.GetHelp(string.Empty);

            Assert.AreEqual("HelpController", result.RouteValues["Controller"]);
            Assert.AreEqual("Index", result.RouteValues["Action"]);
        }

        [Test]
        public void Action_returns_correct_text()
        {
            var controller = new OutputController();
            var result = controller.ShowPlainText("hello world");

            Assert.That(result, Is.EqualTo("hello world"));
        }

        [Test]
        public void Action_returns_text_content()
        {
            var controller = new OutputController();
            ContentResult result = controller.ShowContentResult("Example text");

            Assert.That(result.ContentType, Is.EqualTo("text/plain"));
            Assert.That(result.Content, Is.EqualTo("Example text"));
        }

        [Test]
        public void Action_returns_rss_content()
        {
            var controller = new OutputController();
            ContentResult result = controller.ShowContentResultRss();

            Assert.That(result.ContentType, Is.EqualTo("application/rss+xml"));
        }
    }
}