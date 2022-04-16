using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        User GetUser(User user);

        void Join(int hallId);

        void Exit(int hallId);
    }
}
