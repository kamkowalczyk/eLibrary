using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLibrary.Models;

namespace TestyAplikacji
{
    class TestOne : ICRUDBookRepository
    {
        public Book Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> FindAll()
        {
            throw new NotImplementedException();
        }

        public Book FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
