using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        bool IsLoginUser();

        User GetUser();

        void Join(int hallId);

        void Exit(int hallId);
    }
}
