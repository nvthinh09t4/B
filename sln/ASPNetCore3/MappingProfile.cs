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
            CreateMap<Newspaper, NewspaperDTO>().ReverseMap();
        }
    }
}
