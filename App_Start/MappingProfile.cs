using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Widly.Dtos;
using Widly.Models;

namespace Widly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain To Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            //Dto To Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());

        }
    }
}