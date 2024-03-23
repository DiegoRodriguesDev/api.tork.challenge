using api.tork.challenge.domain.Models;
using api.tork.challenge.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.tork.challenge.webapi.V1.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet] 
        public IActionResult GetBooks(SearchByEnum searchBy, string search)
        {
            return Ok(_bookService.GetBooks(searchBy, search));
        }
    }
}
