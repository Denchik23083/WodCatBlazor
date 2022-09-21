using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        User Login(User loginUser);

        bool Register(User registerUser);
    }
}
