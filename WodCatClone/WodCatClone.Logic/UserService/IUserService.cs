using System.Collections.Generic;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();

        bool IsLoginUser();

        User GetUser();

        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int? id);

        Gender GetGender(string gender);

        bool Update(User updateUser, int id, Gender gender);

        bool UpdateAuth(User updateUser, int id);

        void Join(int hallId);

        void Exit(int hallId);
    }
}
