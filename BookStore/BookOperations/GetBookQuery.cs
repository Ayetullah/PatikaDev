using AutoMapper;
using BookStore.DBOperations;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.BookOperations
{
    public class GetBookQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public int Id { get; set; }

        public GetBookQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public List<BookViewModel> Handle()
        {
            var bookList = _context.Books.OrderBy(x => x.Id).ToList<Book>();
            List<BookViewModel> vm = _mapper.Map<List<BookViewModel>>(bookList);
            return vm;
        }

        public BookViewModel FindBook()
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == Id);
            if(book is null)
            {
                throw new InvalidOperationException("Kitap bulunamadı");
            }

            var viewModel = _mapper.Map<BookViewModel>(book);
            return viewModel;
        }
    }

    public class BookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}
