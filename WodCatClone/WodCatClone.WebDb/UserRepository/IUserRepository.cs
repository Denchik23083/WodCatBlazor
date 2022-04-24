using System.Collections.Generic;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetUser(User user);

        User GetUser(int? id);

        Gender GetGender(int? id);

        void Join(int hallId);

        void Exit(int hallId);
    }
}
