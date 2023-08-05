using AutoMapper;
using CasgemMicroServices.Catalog.Dtos.CategoryDtos;
using CasgemMicroServices.Catalog.Dtos.ProductDtos;
using CasgemMicroServices.Catalog.Models;

namespace CasgemMicroServices.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
        }
    }
}
