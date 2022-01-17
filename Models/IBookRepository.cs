using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> books { get; }
        void addAuthor(int authorId, Author author);
    }
}
