using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.AuthService
{
    public interface IAuthService
    {
        Task<bool> Login(User login);

        Task<bool> Register(User register);

        Task<bool> Logout();
    }
}
