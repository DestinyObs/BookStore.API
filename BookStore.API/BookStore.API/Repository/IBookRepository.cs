using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetBookModelsAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(BookModel bookModel, int bookId);
        Task UpdateBookPatchAsync(JsonPatchDocument bookModel, int bookId);
        Task DeleteBookAsync(int bookId);
    }
}
