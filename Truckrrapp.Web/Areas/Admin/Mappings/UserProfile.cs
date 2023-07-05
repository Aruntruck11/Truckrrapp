using Truckrrapp.Infrastructure.Identity.Models;
using Truckrrapp.Web.Areas.Admin.Models;
using AutoMapper;

namespace Truckrrapp.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}