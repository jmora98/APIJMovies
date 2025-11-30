using APIJMovies.DAL.Models;
using APIJMovies.DAL.Models.Dtos;
using AutoMapper;

namespace APIJMovies.MovieMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CategoryCreateDto>().ReverseMap();
        }
    }
}
