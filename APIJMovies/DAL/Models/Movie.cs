using System.ComponentModel.DataAnnotations;

namespace APIJMovies.DAL.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public int Duration { get; set; }

        [Required]
        [MaxLength(10)]
        public string Clasification { get; set; } = null!;

        public string? Director { get; set; }

        public string? Synopsis { get; set; }
    }
}
