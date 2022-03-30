using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public class UserRepository : IUserRepository
    {
        public static User User;

        public User GetUser(User user)
        {
            User = user;
            
            return User;
        }
    }
}
