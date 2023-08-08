using AutoMapper;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Web.Models;

namespace WodCatClone.Web.Utilities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginModel, User>();

            CreateMap<RegisterModel, User>();
        }
    }
}
