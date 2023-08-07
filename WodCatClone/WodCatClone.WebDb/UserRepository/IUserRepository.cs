using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        Task<User> GetUser(User user);

        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int? id);

        Gender GetGender(string gender);

        bool EditUserHall(User loginUser, int id);

        bool Update(User updateUser, User userToUpdate, Gender gender);

        bool UpdateAuth(User updateUser, User userToUpdate);
    }
}
