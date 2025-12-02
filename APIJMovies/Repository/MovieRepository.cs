using APIJMovies.DAL;
using APIJMovies.DAL.Models;
using APIJMovies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;


namespace APIJMovies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie?> GetMovieAsync(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> CreateMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> UpdateMovieAsync(Movie movie)
        {
            var exist = await _context.Movies.AnyAsync(c => c.Id == movie.Id);

            if (!exist)
                return null;

            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return false;

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
