using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<Gender>> GetGenders();

        bool IsLoginUser();

        User? GetUser();

        Task<User?> GetUser(int id);

        Task<User?> GetUser(string nickName);

        Gender GetGender(int id);

        Task<bool> EditUserHall(User user, int id);

        Task<bool> Update(User updateUser, int id);

        Task<bool> UpdateAuth(User updateAuth, int id);
    }
}
