using BookStore.BookOperations;
using BookStore.DBOperations;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly BookStoreDbContext _context;

        public BooksController(BookStoreDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBookQuery query = new GetBookQuery(_context);
            var books = query.Handle();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooks(int id)
        {
            GetBookQuery query = new GetBookQuery(_context);
            try
            {
                var book = query.FindBook(id);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookCommandViewModel newbook)
        {
            BookCommand createBook = new BookCommand(_context);
            try
            {
                createBook.model = newbook;
                createBook.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] BookCommandViewModel updatebook)
        {
            BookCommand bookCommand = new BookCommand(_context);
            try
            {
                bookCommand.model = updatebook;
                bookCommand.UpdateBook(id);
            }
            catch (Exception ex )
            {
                return BadRequest(ex.Message);
            }
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == id);
            if(book is null)
            {
                return BadRequest();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}
