using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudcore.Models;

namespace crudcore.Repository
{
    interface IbookRepository
    {
        Book GetBook(int bid);
        IEnumerable<Book> GetAllBooks();
        void Add(Book book);
        void Update(Book book);
        void Delete(int bid);
        void save();
    }
}
