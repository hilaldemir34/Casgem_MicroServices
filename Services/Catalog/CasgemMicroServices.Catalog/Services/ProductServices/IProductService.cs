using CasgemMicroServices.Catalog.Dtos.CategoryDtos;
using CasgemMicroservices.Shared.Dtos;
using CasgemMicroServices.Catalog.Dtos.ProductDtos;

namespace CasgemMicroServices.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetProductListAsync();
        Task<Response<ResultProductDto>> GetProductByIdAsync(string id);
        Task<Response<CreateProductDto>> GetProductAsync(CreateProductDto createProduct);
        Task<Response<UpdateProductDto>> UpdateProductAsync(UpdateProductDto updateProduct);
        Task<Response<NoContent>> DeleteProductAsync(string id);
        Task<Response<List<ResultProductDto>>> GetProductListWithCategoryAsync();
    }
}
