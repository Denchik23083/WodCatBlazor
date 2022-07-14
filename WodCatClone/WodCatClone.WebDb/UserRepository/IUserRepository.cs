using System.Collections.Generic;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetUser(User user);

        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int? id);

        Gender GetGender(string gender);

        bool EditUserHall(User user, int id);

        bool EditUserProgram(User user, int id);

        bool Update(User editUser, int id);

        bool UpdateAuth(User updateUser, int id);
    }
}
