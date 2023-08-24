using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<IEnumerable<Gender>> GetGenders();
        
        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int id);

        bool EditUserHall(User loginUser, int id);

        bool Update(User updateUser, User userToUpdate);

        bool UpdateAuth(User updateUser, User userToUpdate);
    }
}
