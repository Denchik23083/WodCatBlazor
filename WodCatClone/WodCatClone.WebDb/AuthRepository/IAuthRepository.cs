using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        Task<User?> Login(User loginUser);

        Task<bool> Register(User registerUser);
    }
}
