using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<Gender>> GetGenders();
        
        User? GetUser(int id);

        Task<User?> GetUser(string nickName);

        Task<bool> EditUserHall(User loginUser);

        Task<bool> Update(User userToUpdate);

        Task<bool> UpdateAuth(User userToUpdate);
    }
}
