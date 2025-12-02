using API.J.Movies.DAL.Dtos.Category;
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


        //
        public async Task<CategoryDto> CreateCategoryAsync(CategoryCreateUpdateDto categoryCreateDto)
        {
            //Validar si la categoría ya existe
            var categoryExists = await _categoryRepository.GetCategoryByNameAsync(categoryCreateDto.Name);

            if (categoryExists)
            {
                throw new InvalidOperationException($"Ya existe una categoría con el nombre de '{categoryCreateDto.Name}'");
            }

            //Mapear el DTO a la entidad
            var category = _mapper.Map<Category>(categoryCreateDto);

            //Crear la categoría en el repositorio
            var categoryCreated = await _categoryRepository.CreateCategoryAsync(category);

            if (!categoryCreated)
            {
                throw new Exception("Ocurrió un error al crear la categoría.");
            }

            //Mapear la entidad creada a DTO
            return _mapper.Map<CategoryDto>(category);
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
