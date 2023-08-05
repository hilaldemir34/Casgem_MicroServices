using CasgemMicroservices.Shared.Dtos;
using CasgemMicroServices.Catalog.Dtos.CategoryDtos;

namespace CasgemMicroServices.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetCategoryListAsync();   
        Task<Response<ResultCategoryDto>> GetCategoryByIdAsync(string id);   
        Task<Response<CreateCategoryDto>> GetCategoryAsync(CreateCategoryDto createCategory);   
        Task<Response<UpdateCategoryDto>> UpdateCategoryAsync(UpdateCategoryDto updateCategory);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);


    }
}
