

using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class BooksController : BaseApiController
    {
        private readonly DataContext _context;
        public BooksController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet]  //api/books
        public async Task<ActionResult<List<Book>>> GetBooks () {

            return await _context.Books.ToListAsync() ;
        }


         [HttpGet("{id}")]  //api/books/id
          public async Task<ActionResult<Book>> GetBook (Guid id)
        {

            return await _context.Books.FindAsync(id) ;
        }
         
    }
}