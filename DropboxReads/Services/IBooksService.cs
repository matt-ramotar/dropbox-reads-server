using DropboxReads.Models;

namespace DropboxReads.Services
{
    public interface IBooksService
    {
        Task CreateAsync(Book newBook);
        Task<List<Book>> GetAsync();
        Task<Book?> GetAsync(string id);
        Task RemoveAsync(string id);
        Task UpdateAsync(string id, Book updatedBook);
    }
}