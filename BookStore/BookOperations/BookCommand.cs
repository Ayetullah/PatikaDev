using AutoMapper;
using BookStore.DBOperations;
using BookStore.Models;
using FluentValidation;
using System;
using System.Linq;

namespace BookStore.BookOperations
{
    public class BookCommand
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public BookCommandViewModel model { get; set; }
        public int Id { get; set; }
        public BookCommand(BookStoreDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _context.Books.FirstOrDefault(x => x.Title == model.Title);
            if(book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut");
            }

            book = _mapper.Map<Book>(model);
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook()
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == Id);
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

        public void DeleteBook()
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == Id);
            if (book is null)
            {
                throw new Exception("Kitap bulunamadı");
            }

            _context.Books.Remove(book);
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

    public class BookCommandUpdateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }

    public class BookCommandValidator: AbstractValidator<BookCommandViewModel>
    {
        public BookCommandValidator(ProcessType processType)
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
            switch (processType)
            {
                case ProcessType.Undefined:
                    break;
                case ProcessType.Add:
                    RuleFor(command => command.PageCount).GreaterThan(0);
                    RuleFor(command => command.PublishDate).NotEmpty().LessThan(DateTime.Now.Date);
                    RuleFor(command => command.Title).NotEmpty().MinimumLength(4);
                    break;
                case ProcessType.Update:
                    break;
            }
        }
    }

    public class BookCommandIdValidator : AbstractValidator<int>
    {
        public BookCommandIdValidator()
        {
            RuleFor(command => command).GreaterThan(0);
        }
    }
}
