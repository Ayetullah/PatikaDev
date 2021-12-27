using AutoMapper;
using BookStore.BookOperations;
using BookStore.DBOperations;
using BookStore.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public BooksController(BookStoreDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBookQuery query = new GetBookQuery(_context, _mapper);
            var books = query.Handle();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooks(int id)
        {
            GetBookQuery query = new GetBookQuery(_context, _mapper);
            try
            {
                query.Id = id;
                BookCommandIdValidator validatior = new BookCommandIdValidator();
                validatior.ValidateAndThrow(query.Id);
                var book = query.FindBook();
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
            BookCommand createBook = new BookCommand(_context, _mapper);
            try
            {
                createBook.model = newbook;
                BookCommandValidator validatior = new BookCommandValidator(ProcessType.Add);
                validatior.ValidateAndThrow(createBook.model);
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
            BookCommand bookCommand = new BookCommand(_context, _mapper);
            try
            {
                bookCommand.model = updatebook;
                bookCommand.Id = id;
                BookCommandIdValidator validator = new BookCommandIdValidator();
                validator.ValidateAndThrow(bookCommand.Id);
                bookCommand.UpdateBook();
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
            try
            {
                BookCommand bookCommand = new BookCommand(_context, _mapper);
                bookCommand.Id = id;
                BookCommandValidator validator = new BookCommandValidator(ProcessType.Delete);
                validator.ValidateAndThrow(bookCommand.model);
                bookCommand.DeleteBook();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
