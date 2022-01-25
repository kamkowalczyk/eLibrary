using System;
using Xunit;
using eLibrary.Controllers;
using eLibrary.Models;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace BookTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            ICRUDBookRepository _bookList = new MemoBookRepository();
            BookController controller = new BookController(_bookList);
            CreateViewModel viewModel = new CreateViewModel();
            Assert.NotNull(viewModel);
        }
        [Fact]
        public void TestAdd()
        {
            ICRUDBookRepository books = new MemoBookRepository();
            BookController controller = new BookController(books);
            controller.Add(new CreateViewModel() {Id=5, Title= "Projekt Riese", Authors="Remigiusz Mróz", PublishingYear= new DateTime(), ISBN="6543643653132", Pages=452 });

        }
        [Fact]
        public void TestAddForm()
        {
            var mock = new Mock<ICRUDBookRepository>();

            var controller = new BookController(mock.Object);
            var res = controller.Add(new CreateViewModel() { Id = 1 });

            mock.Verify(v => v.Add(It.IsAny<Book>()));

        }
        [Fact]
        public void TestDelete()
        {

            var book = new Book() { Id = 1 };

            var mock = new Mock<ICRUDBookRepository>();
            var controller = new BookController(mock.Object);

            var res = controller.Delete(1);



            mock.Verify(v => v.Delete(1), Times.Once());
        }

        [Fact]
        public void TestUpdate()
        {

            var book = new Book() { Id = 1 };
            var book2 = new EditViewModel() { Id = 1 };
            var mock = new Mock<ICRUDBookRepository>();
            mock.Setup(v => v.FindById(1)).Returns(book);
            var controller = new BookController(mock.Object);

            var res = controller.Edit(book2);

            mock.Verify(v => v.Update(It.IsAny<Book>()), Times.Once());
        }
    }
}
