using APIJMovies.DAL.Models;
using APIJMovies.DAL.Models.Dtos;
using APIJMovies.Repository.IRepository;
using APIJMovies.Service.IService;

namespace APIJMovies.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repo;

        public MovieService(IMovieRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<MovieDto>> GetMoviesAsync()
        {
            var movies = await _repo.GetMoviesAsync();

            return movies.Select(m => new MovieDto
            {
                Id = m.Id,
                Name = m.Name,
                Duration = m.Duration,
                Clasification = m.Clasification,
                Director = m.Director,
                Synopsis = m.Synopsis
            });
        }

        public async Task<MovieDto?> GetMovieAsync(int id)
        {
            var m = await _repo.GetMovieAsync(id);
            if (m == null) return null;

            return new MovieDto
            {
                Id = m.Id,
                Name = m.Name,
                Duration = m.Duration,
                Clasification = m.Clasification,
                Director = m.Director,
                Synopsis = m.Synopsis
            };
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateDto dto)
        {
            var movie = new Movie
            {
                Name = dto.Name,
                Duration = dto.Duration,
                Clasification = dto.Clasification,
                Director = dto.Director,
                Synopsis = dto.Synopsis
            };

            movie = await _repo.CreateMovieAsync(movie);

            return new MovieDto
            {
                Id = movie.Id,
                Name = movie.Name,
                Duration = movie.Duration,
                Clasification = movie.Clasification,
                Director = movie.Director,
                Synopsis = movie.Synopsis
            };
        }

        public async Task<MovieDto?> UpdateMovieAsync(int id, MovieUpdateDto dto)
        {
            var movie = new Movie
            {
                Id = id,
                Name = dto.Name,
                Duration = dto.Duration,
                Clasification = dto.Clasification,
                Director = dto.Director,
                Synopsis = dto.Synopsis
            };

            var updated = await _repo.UpdateMovieAsync(movie);
            if (updated == null)
                return null;

            return new MovieDto
            {
                Id = updated.Id,
                Name = updated.Name,
                Duration = updated.Duration,
                Clasification = updated.Clasification,
                Director = updated.Director,
                Synopsis = updated.Synopsis
            };
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            return await _repo.DeleteMovieAsync(id);
        }
    }
}
