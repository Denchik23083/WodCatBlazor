using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<Gender>> GetGenders();

        bool IsLoginUser();

        Task<User?> GetUser();

        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int id);

        bool EditUserHall(User user, int id);

        bool Update(User updateUser, int id, string genderName);

        Task<bool> UpdateAuth(User updateUser, int id);
    }
}
