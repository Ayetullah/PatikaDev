using BookStore.DBOperations;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookOperations
{
    public class GetBookQuery
    {
        private readonly BookStoreDbContext _context;

        public GetBookQuery(BookStoreDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<BookViewModel> Handle()
        {
            var bookList = _context.Books.OrderBy(x => x.Id).ToList<Book>();
            List<BookViewModel> vm = new List<BookViewModel>();
            foreach (var item in bookList)
            {
                vm.Add(new BookViewModel() {
                    Title = item.Title,
                    PageCount = item.PageCount,
                    Genre = ((GenreEnum)item.GenreId).ToString(),
                    PublishDate  = item.PublishDate.Date.ToString("dd/MM/yyy")              
                });
            }
            return vm;
        }

        public BookViewModel FindBook(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if(book is null)
            {
                throw new InvalidOperationException("Kitap bulunamadı");
            }

            BookViewModel viewModel = new BookViewModel();
            viewModel.Genre = ((GenreEnum) book.GenreId).ToString();
            viewModel.Title = book.Title;
            viewModel.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy");
            viewModel.PageCount = book.PageCount;
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
