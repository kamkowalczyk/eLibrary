using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Models
{
    public interface ICRUDBookRepository
    {
        Book Add(Book book);

        void Delete(int id);

        Book Update(Book book);

        Book FindById(int id);

        IList<Book> FindAll();

        IList<Book> FindPage(int page, int size);

        void AddAuthorToBook(int authorId, int bookId);
    }
    public class EFCRUDBookRepository : ICRUDBookRepository
    {
        private ApplicationDbContext context;

        public EFCRUDBookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Book Add(Book book)
        {
            EntityEntry<Book> entityEntry = context.Books.Add(book);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public void Delete(int id)
        {
            context.Books.Remove(context.Books.Find(id));
            context.SaveChanges();
        }

        public IList<Book> FindAll()
        {
            return context.Books.ToList();
        }

        public Book FindById(int id)
        {
           
            return context.Books.Find(id);
        }

        public IList<Book> FindPage(int page, int size)
        {
            return (from book in context.Books orderby book.Title select book)
                .Skip(page * size)
                .Take(size)
                .ToList();
        }

        public void AddAuthorToBook(int authorId, int bookId)
        {
           
            var book = context.Books.Find(bookId);
          
            Update(book);
        }

        public Book Update(Book book)
        {
            EntityEntry<Book> entityEntry = context.Books.Update(book);
            context.SaveChanges();
            return entityEntry.Entity;
        }
    }

}
