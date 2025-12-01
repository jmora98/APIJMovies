using APIJMovies.DAL.Models;
using APIJMovies.DAL.Models.Dtos;
using APIJMovies.Repository;
using APIJMovies.Repository.IRepository;
using APIJMovies.Service.IService;
using AutoMapper;

namespace APIJMovies.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        { 
            var catetegories = await _categoryRepository.GetCategoriesAsync(); //llama el metodo desde el repositorio
            return _mapper.Map<ICollection<CategoryDto>>(catetegories); //mape el modelo oringial y lo entrega como DTO ( solo lo necesario )

        }

        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            var catetegories = await _categoryRepository.GetCategoryAsync(id); 
            return _mapper.Map<CategoryDto>(catetegories); 
        }

        public async Task<bool> GetCategoryByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
