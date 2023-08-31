using AutoMapper;
using WodCatClone.Db.Entities.Actions;
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

            CreateMap<ResultWorkoutsModel, ResultWorkouts>();
            CreateMap<ResultWorkouts, ResultWorkoutsModel>();

            CreateMap<ArticlesModel, Articles>();
            CreateMap<Articles, ArticlesModel>();

            CreateMap<HallsModel, Halls>();
            CreateMap<Halls, HallsModel>();
        }
    }
}
