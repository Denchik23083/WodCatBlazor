using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<IEnumerable<Gender>> GetAllGendersAsync();
        
        Task<User?> GetUserAsync(int id);

        Task<User?> GetUserAsync(string nickName);

        Task<bool> EditUserHallAsync(User loginUser);

        Task<bool> UpdateAsync(User userToUpdate);

        Task<bool> UpdateAuthAsync(User userToUpdate);
    }
}
