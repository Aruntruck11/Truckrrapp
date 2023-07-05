using Truckrrapp.Application.Features.Brands.Commands.Create;
using Truckrrapp.Application.Features.Brands.Queries.GetAllCached;
using Truckrrapp.Application.Features.Brands.Queries.GetById;
using Truckrrapp.Domain.Entities.Catalog;
using AutoMapper;

namespace Truckrrapp.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}