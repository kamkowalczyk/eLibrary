using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLibrary.Models;

namespace BookTest
{
    internal class MemoBookRepository : ICRUDBookRepository
    {
        private List<Book> _bookList;

        public MemoBookRepository()
        {
            _bookList = new List<Book>()
            {
                new Book(){Id=1, Title="Ballady i romanse", Authors="Adam Mickiewicz", PublishingYear=new DateTime(),ISBN="12345678910121",Pages=123},
                new Book(){Id=2, Title="Jaś i Małgosia", Authors="Bracia Grimm", PublishingYear=new DateTime(),ISBN="3123131221312",Pages=328},
                new Book(){Id=3, Title="Księgi Jakubowe", Authors="Olga Tokarczuk", PublishingYear=new DateTime(),ISBN="12345672110121",Pages=531},
                new Book(){Id=4, Title="Teoria wszystkiego, czyli krótka historia wszechświata", Authors="Stephen Hawking", PublishingYear=new DateTime(),ISBN="42345672112121",Pages=523},
            };
        }
        public Book Add(Book book)
        {
            book.Id = _bookList.Max(e => e.Id) + 1;
            _bookList.Add(book);
            return book;
        }

        public void Delete(int id)
        {
            Book book = _bookList.FirstOrDefault(e => e.Id == id);
            if (book != null)
            {
                _bookList.Remove(book);
            }
          
        }

        public IList<Book> FindAll()
        {
            return _bookList;
        }

        public Book FindById(int id)
        {
            return _bookList.FirstOrDefault(e => e.Id == id);
        }


        public Book Update(Book book)
        {
            Book original = _bookList.FirstOrDefault(e=>e.Id ==book.Id);
            if (book != null)
            {
                original.Title = book.Title;
                original.Authors = book.Authors;
                original.PublishingYear = book.PublishingYear;
                original.ISBN = book.ISBN;
                original.Pages = book.Pages;
            }
            return original;
        }
        
    }
}
