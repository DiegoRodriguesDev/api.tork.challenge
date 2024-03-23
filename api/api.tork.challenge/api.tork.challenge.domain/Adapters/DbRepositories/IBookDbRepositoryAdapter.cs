using api.tork.challenge.domain.Models;

namespace api.tork.challenge.domain.Adapters.DbRepositories
{
    public interface IBookDbRepositoryAdapter
    {
        public List<Book> GetAllBooks();
        public List<Book> GetBooksByTitle(string title);
        public List<Book> GetBooksByCategory(string category);
    }
}
