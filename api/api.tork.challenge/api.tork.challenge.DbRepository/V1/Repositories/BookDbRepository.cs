using api.tork.challenge.DbRepository.Context;
using api.tork.challenge.DbRepository.V1.DTOs;
using api.tork.challenge.domain.Adapters.DbRepositories;
using api.tork.challenge.domain.Models;
using AutoMapper;
using System.Data;

namespace api.tork.challenge.DbRepository.V1.Repositories
{
    public class BookDbRepository : IBookDbRepositoryAdapter
    {
        private readonly IMapper _mapper;
        
        public BookDbRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            using (var context = new ApiDbContext())
            {
                List<BookDto> booksDto = context.Books.ToList();
                books = _mapper.Map<List<Book>>(booksDto);
            }
            return books;
        }

        public List<Book> GetBooksByCategory(string category)
        {
            var books = new List<Book>();
            using (var context = new ApiDbContext())
            {
                List<BookDto> booksDto = context.Books.Where(b => b.category.Contains(category)).ToList();
                books = _mapper.Map<List<Book>>(booksDto);
            }
            return books;
        }

        public List<Book> GetBooksByTitle(string title)
        {
            var books = new List<Book>();
            using (var context = new ApiDbContext())
            {
                List<BookDto> booksDto = context.Books.Where(b => b.title.Contains(title)).ToList();
                books = _mapper.Map<List<Book>>(booksDto);
            }
            return books;
        }
    }
}
