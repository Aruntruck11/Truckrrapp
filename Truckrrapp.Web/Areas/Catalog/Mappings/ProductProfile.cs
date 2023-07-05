using Truckrrapp.Application.Features.Products.Commands.Create;
using Truckrrapp.Application.Features.Products.Commands.Update;
using Truckrrapp.Application.Features.Products.Queries.GetAllCached;
using Truckrrapp.Application.Features.Products.Queries.GetById;
using Truckrrapp.Web.Areas.Catalog.Models;
using AutoMapper;

namespace Truckrrapp.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}