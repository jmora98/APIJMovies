namespace APIJMovies.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public string Clasification { get; set; } = null!;
        public string? Director { get; set; }
        public string? Synopsis { get; set; }
    }
}
