using System.Threading.Tasks;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.AuthService
{
    public interface IAuthService
    {
        Task<bool> Login(Login login);

        Task<bool> Register(Register register);

        bool Logout();
    }
}
