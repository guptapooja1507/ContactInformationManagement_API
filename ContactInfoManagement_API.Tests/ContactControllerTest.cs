using ContactInfoManagement_API.BusinessLayer.Interface;
using ContactInfoManagement_API.Controller;
using ContactInfoManagement_API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;

namespace ContactInfoManagement_API.Tests
{
    [TestClass]
    public class ContactControllerTest
    {
        [TestMethod]
        public void GetReturnsNotFound()
        {
            //Action returns 404(Not Found)
            // Arrange
            var mockRepository = new Mock<IContactManager>();
            var controller = new ContactController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.DeleteContact(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(HttpStatusCode));
        }

        //Action returns 200 (OK) with no response body
        [TestMethod]
        public void DeleteReturnsOk()
        {
            // Arrange
            var mockRepository = new Mock<IContactManager>();
            var controller = new ContactController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.DeleteContact(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(HttpStatusCode));
        }

        //Action returns 201 (Created) with a Location header
        [TestMethod]
        public void PostMethodSetsLocationHeader()
        {
            // Arrange
            var mockRepository = new Mock<IContactManager>();
            var controller = new ContactController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.AddContact(new Models.Contact { Id = 10, FirstName = "contact1" });
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Contact>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.AreEqual(10, createdResult.RouteValues["id"]);
        }

        //Action returns another 2xx with a response body
        [TestMethod]
        public void PutReturnsContentResult()
        {
            // Arrange
            var mockRepository = new Mock<IContactManager>();
            var controller = new ContactController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.EditContact(10, new Contact { Id = 10, FirstName = "contact1" });
            var contentResult = actionResult as NegotiatedContentResult<Contact>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(10, contentResult.Content.Id);
        }
    }
}
