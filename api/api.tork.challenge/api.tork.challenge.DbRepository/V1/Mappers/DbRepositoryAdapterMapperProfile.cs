using api.tork.challenge.domain.Models;
using AutoMapper;

namespace api.tork.challenge.DbRepository.V1.Mappers
{
    public class DbRepositoryAdapterMapperProfile: Profile
    {
        public DbRepositoryAdapterMapperProfile()
        {
            CreateMap<DTOs.BookDto, Book>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.book_id))
                .ForMember(x => x.Title, x => x.MapFrom(y => y.title))
                .ForMember(x => x.FirstName, x => x.MapFrom(y => y.first_name))
                .ForMember(x => x.LastName, x => x.MapFrom(y => y.last_name))
                .ForMember(x => x.TotalCopies, x => x.MapFrom(y => y.total_copies))
                .ForMember(x => x.CopiesInUse, x => x.MapFrom(y => y.copies_in_use))
                .ForMember(x => x.Type, x => x.MapFrom(y => y.type))
                .ForMember(x => x.Isbn, x => x.MapFrom(y => y.isbn))
                .ForMember(x => x.Category, x => x.MapFrom(y => y.category))
            ;
        }
    }
}
