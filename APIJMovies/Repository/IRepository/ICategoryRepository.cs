using APIJMovies.DAL.Models;

namespace APIJMovies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // Me retornar  UNA LISTA DE CATEGORIAS
        Task<Category> GetCategoryAsync (int id); // Me retorna una solo objeto de categories
        Task<bool> CategoryExistsByIdAsync (int id); // me valida si existe una categoria por id true/false
        Task<bool> GetCategoryByNameAsync (string name); // me valida si existe por nombre
        Task<bool> CreateCategoryAsync (Category category);
        Task<bool> UpdateCategoryAsync (Category category);
        Task<bool> DeleteCategoryAsync (int id);

    }
}
