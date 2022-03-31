using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapidemojwt.Data;
using webapidemojwt.Models;

namespace webapidemojwt.Repository
{
    public interface IBookRepository
    {
        Task<List<Books>> GetAllBooksAsync();
        Task<Books> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(Books bookModel);
        Task UpdateBookAsync(int bookId, Books bookModel);
        Task DeleteBookAsync(int bookId);
    }
}
