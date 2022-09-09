using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        User Login(Login login);

        bool Register(Register register);
    }
}
