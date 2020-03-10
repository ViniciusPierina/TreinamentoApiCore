using AutoMapper;
using Domain.Commands;
using Domain.Models;
using Services.DTOs;

namespace Services.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<CreateCityCommand, CreateCityDTO>().ReverseMap();
            CreateMap<UpdateCityCommand, UpdateCityDTO>().ReverseMap();
            CreateMap<City, CreateCityCommand>().ReverseMap();
            CreateMap<City, UpdateCityCommand>().ReverseMap();

            CreateMap<Game, GameDTO>().ReverseMap();
            CreateMap<CreateGameCommand, CreateGameDTO>().ReverseMap();
            CreateMap<UpdateGameCommand, UpdateGameDTO>().ReverseMap();
            CreateMap<Game, CreateGameCommand>().ReverseMap();
            CreateMap<Game, UpdateGameCommand>().ReverseMap();
        }
    }
}
