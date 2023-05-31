using AutoMapper;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Request;

namespace BanVeXemPhimApi.Mapper
{
    public class MappingContext : Profile
    {
        public MappingContext()
        {
            // user request
            CreateMap<UserRegisterRequest, User>();

            // schedule
            CreateMap<Schedule, ScheduleDto>();

            // Movie
            CreateMap<MovieStoreRequest, Movie>();
            CreateMap<Movie, MovieWithScheduleDto>();

            // Cinema
            CreateMap<CinemaStoreRequest, Cinema>();
        }
    }
}
