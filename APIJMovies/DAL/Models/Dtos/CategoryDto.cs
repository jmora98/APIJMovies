using System.ComponentModel.DataAnnotations;

namespace APIJMovies.DAL.Models.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = " El nombre de la categoria es obligatorio")]
        [MaxLength(100, ErrorMessage = "El numero maximo de carateres es de 100.")]
        public string Name { get; set; }
        public string CreateDate { get; set; }
        public string ModifieDate { get; set; }

    }
}
