using APIJMovies.DAL.Models.Dtos;
using APIJMovies.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIJMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _service.GetMoviesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var movie = await _service.GetMovieAsync(id);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieCreateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var movie = await _service.CreateMovieAsync(dto);
            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, [FromBody] MovieUpdateDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var movie = await _service.UpdateMovieAsync(id, dto);
            if (movie == null) return NotFound();

            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var deleted = await _service.DeleteMovieAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
