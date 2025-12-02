using APIJMovies.DAL.Models;

namespace APIJMovies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie?> GetMovieAsync(int id);
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie?> UpdateMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(int id);
    }
}
