using ASPNetCore3.Models.DTO;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Newspaper, NewspaperDto>();
            CreateMap<NewspaperDto, Newspaper>()
                .ForMember(i => i.SubCategories, o => o.Ignore());

            CreateMap<Book, BookDto>()
                .ForMember(i => i.CreatedAt, o => o.MapFrom(src => src.CreatedOn.ToString("dd/MM/yyyy")))
                .ForMember(i => i.Name, o => o.MapFrom(src => src.FileStorage.OriginFileName));
        }
    }
}
