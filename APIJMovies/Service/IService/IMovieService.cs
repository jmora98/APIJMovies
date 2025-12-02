using APIJMovies.DAL.Models.Dtos;

namespace APIJMovies.Service.IService
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetMoviesAsync();
        Task<MovieDto?> GetMovieAsync(int id);
        Task<MovieDto> CreateMovieAsync(MovieCreateDto dto);
        Task<MovieDto?> UpdateMovieAsync(int id, MovieUpdateDto dto);
        Task<bool> DeleteMovieAsync(int id);
    }
}
