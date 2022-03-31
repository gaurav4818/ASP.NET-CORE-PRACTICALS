using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudcore.Models;
using crudcore.Repository;
using Microsoft.EntityFrameworkCore;

namespace crudcore.Repository
{
    public class BookRepository : IbookRepository
    {
        private readonly BookContext context;
        public BookRepository(BookContext bookContext)
        {
            this.context = bookContext;
        }

        public void Add(Book book)
        {
            context.Books.Add(book);
        }


        public void Delete(int bid)
        {
            Book book = context.Books.FirstOrDefault(x => x.BookId==bid);
            context.Books.Remove(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public Book GetBook(int bid)
        {
            return context.Books.FirstOrDefault(x => x.BookId == bid);
        }

        public void Update(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
        }
        public void save()
        {
            context.SaveChanges();
        }
    }
}

