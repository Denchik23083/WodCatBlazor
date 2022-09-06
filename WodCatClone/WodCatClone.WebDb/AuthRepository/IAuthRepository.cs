using System.Threading.Tasks;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        Task<User> Login(Login login);

        Task<bool> Register(Register register);
    }
}
