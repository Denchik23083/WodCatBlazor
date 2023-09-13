using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.AuthService
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(User login);

        Task<bool> RegisterAsync(User register);

        Task<bool> LogoutAsync();
    }
}
