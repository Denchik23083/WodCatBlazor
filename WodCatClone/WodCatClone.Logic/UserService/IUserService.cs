using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<IEnumerable<Gender>> GetAllGendersAsync();

        Task<bool> IsLoginUserAsync();

        Task<User?> GetUserAsync();

        Task<User?> GetUserAsync(string nickName);

        Task<bool> EditUserHallAsync(User user, int id);

        Task<bool> UpdateAsync(User updateUser, int id);

        Task<bool> UpdateAuthAsync(User updateAuth, int id);
    }
}
