using BookStore.DBOperations;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookOperations
{
    public class BookCommand
    {
        private readonly BookStoreDbContext _context;
        public BookCommandViewModel model { get; set; }
        public BookCommand(BookStoreDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(x => x.Title == model.Title);
            if(book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut");
            }

            book = new Book();
            book.Title = model.Title;
            book.PublishDate = model.PublishDate;
            book.PageCount = model.PageCount;
            book.GenreId = model.GenreId;
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(int id)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == id);
            if (book is null)
            {
                throw new Exception("Kitap bulunamadı");
            }

            book.GenreId = model.GenreId != default ? model.GenreId : book.GenreId;
            book.PageCount = model.PageCount != default ? model.PageCount : book.PageCount;
            book.PublishDate = model.PublishDate != default ? model.PublishDate : book.PublishDate;
            book.Title = model.Title != default ? model.Title : book.Title;
            _context.SaveChanges();
        }
    }

    public class BookCommandViewModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
