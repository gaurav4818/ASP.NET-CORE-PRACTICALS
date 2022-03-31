using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapidemojwt.Data;
using webapidemojwt.Models;

namespace webapidemojwt.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
           
        }
        public async Task<int> AddBookAsync(Books bookModel)
        {
             _context.Books.Add(bookModel);
            await _context.SaveChangesAsync();

            return bookModel.Id;
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book= await _context.Books.Where(x => x.Id == bookId).FirstOrDefaultAsync();
            if (book != null)
            {
                 _context.Books.Remove(book);
                 await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Books>> GetAllBooksAsync()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }

        public async Task<Books> GetBookByIdAsync(int bookId)
        {
            var book = await _context.Books.Where(x => x.Id == bookId).FirstOrDefaultAsync();
            return book;
        }

        public async Task UpdateBookAsync(int bookId, Books bookModel)
        {
            var book = await _context.Books.Where(x => x.Id == bookId).FirstOrDefaultAsync();
            if (book != null)
            {
                book.Id = bookId;
                book.Title = bookModel.Title;
                book.Description = bookModel.Description;
          
                await _context.SaveChangesAsync();
            }
        }



    }
}
