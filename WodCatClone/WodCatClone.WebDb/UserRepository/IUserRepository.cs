using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        User GetUser(User user);

        bool Join(int hallId);
    }
}
