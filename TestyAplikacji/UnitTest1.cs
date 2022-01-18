using eLibrary.Controllers;
using eLibrary.Models;
using System;
using Xunit;

namespace TestyAplikacji
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ICRUDBookRepository books = new Testy();
            BookController controller = new BookController(books);
        
        }
    }
}
