using AutoMapper;
using BookStore.BookOperations;

namespace BookStore.Models
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<BookCommandViewModel, Book>();
            CreateMap<Book, BookViewModel>()
                .ForMember(x => x.Genre, opt => opt.MapFrom(o => ((GenreEnum)o.GenreId).ToString()))
                .ForMember(x => x.PublishDate, opt => opt.MapFrom(o => o.PublishDate.Date.ToString("dd/MM/yyy")));
        }
    }
}
