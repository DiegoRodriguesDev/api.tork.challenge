using api.tork.challenge.domain.Models;

namespace api.tork.challenge.domain.Services
{
    public interface IBookService
    {
        public List<Book> GetBooks(SearchByEnum searchBy, string search);
    }
}
