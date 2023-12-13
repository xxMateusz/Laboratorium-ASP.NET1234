using Laboratorium3___App.Controllers;
using Laboratorium3___App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Moq;

namespace Laboratorium_9
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        private IDateTimeProvider _dateTimeProvider;

        public ContactControllerTest()
        {
            _dateTimeProvider = new CurrentDateTimeProvider();
            _service = new MemoryContactService(_dateTimeProvider);
            _service.Add(new Contact() { Id = 1 });
            _service.Add(new Contact() { Id = 2 });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            Assert.IsType<List<Contact>>(view.Model);
            var list = view.Model as List<Contact>;
            Assert.Equal(_service.FindAll().Count, list.Count);
        }

       

        [Theory]
        [InlineData(45)]
        [InlineData(99)]
        public void DetailsTestForNotExistingContact(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}