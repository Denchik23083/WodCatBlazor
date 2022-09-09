using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.AuthService
{
    public interface IAuthService
    {
        bool Login(Login login);

        bool Register(Register register);

        bool Logout();
    }
}
