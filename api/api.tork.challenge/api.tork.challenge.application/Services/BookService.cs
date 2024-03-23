using api.tork.challenge.domain.Adapters.DbRepositories;
using api.tork.challenge.domain.Models;
using api.tork.challenge.domain.Services;

namespace api.tork.challenge.application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookDbRepositoryAdapter _bookDbRepository;

        public BookService(IBookDbRepositoryAdapter bookDbRepository)
        {
            _bookDbRepository = bookDbRepository;
        }

        public List<Book> GetBooks(SearchByEnum searchBy, string search)
        {
            try
            {
                ValidateGetBooks(searchBy, search);

                List<Book> books = new List<Book>();

                switch (searchBy)
                {
                    case SearchByEnum.Title:
                        {
                            books = _bookDbRepository.GetBooksByTitle(search);
                            break;
                        }
                    case SearchByEnum.Category:
                        {
                            books = _bookDbRepository.GetBooksByCategory(search);
                            break;
                        }
                    default: break;
                }

                return books;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ValidateGetBooks(SearchByEnum searchBy, string search)
        {
            if (searchBy == null || searchBy == SearchByEnum.None)
            {
                throw new ArgumentNullException("SearchBy field is required");
            }

            if (string.IsNullOrEmpty(search))
            {
                throw new ArgumentNullException("Search field is required");
            }
        }
    }
}
