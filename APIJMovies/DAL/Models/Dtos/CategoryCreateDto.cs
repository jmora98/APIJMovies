using System.ComponentModel.DataAnnotations;

namespace APIJMovies.DAL.Models.Dtos
{
    public class CategoryCreateDto
    {
        [Required(ErrorMessage = " El nombre de la categoria es obligatorio")]
        [MaxLength(100,ErrorMessage ="El numero maximo de carateres es de 100.")]
        public string Name { get; set; }
    }
}
