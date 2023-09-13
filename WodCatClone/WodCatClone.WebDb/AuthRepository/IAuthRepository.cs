using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        Task<User?> LoginAsync(User loginUser);

        Task<bool> RegisterAsync(User registerUser);
    }
}
