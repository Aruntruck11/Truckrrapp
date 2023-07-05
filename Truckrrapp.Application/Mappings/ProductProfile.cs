using Truckrrapp.Application.Features.Products.Commands.Create;
using Truckrrapp.Application.Features.Products.Queries.GetAllCached;
using Truckrrapp.Application.Features.Products.Queries.GetAllPaged;
using Truckrrapp.Application.Features.Products.Queries.GetById;
using Truckrrapp.Domain.Entities.Catalog;
using AutoMapper;

namespace Truckrrapp.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}