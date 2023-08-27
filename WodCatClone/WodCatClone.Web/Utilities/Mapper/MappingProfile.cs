using AutoMapper;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Web.Models;

namespace WodCatClone.Web.Utilities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginModel, User>();

            CreateMap<RegisterModel, User>();
            CreateMap<User, RegisterModel>();

            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();
        }
    }
}
