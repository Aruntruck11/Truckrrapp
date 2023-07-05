using Truckrrapp.Application.Features.Brands.Commands.Create;
using Truckrrapp.Application.Features.Brands.Commands.Update;
using Truckrrapp.Application.Features.Brands.Queries.GetAllCached;
using Truckrrapp.Application.Features.Brands.Queries.GetById;
using Truckrrapp.Web.Areas.Catalog.Models;
using AutoMapper;

namespace Truckrrapp.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}