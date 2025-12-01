using APIJMovies.DAL.Models;
using APIJMovies.DAL.Models.Dtos;

namespace APIJMovies.Service.IService
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto> GetCategoryAsync(int id); 
        Task<bool> CategoryExistsByIdAsync(int id); 
        Task<bool> GetCategoryByNameAsync(string name); 
        Task<bool> CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
