using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.AuthRepository;

namespace WodCatClone.Logic.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        public static bool IsLoginUser;
        public static User User;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public bool Login(Login login)
        {
            var user = _repository.Login(login);

            if (user is null)
            {
                return false;
            }

            User = user;
            IsLoginUser = true;

            return true;
        }

        public bool Register(Register register)
        {
            return _repository.Register(register);
        }

        public bool Logout()
        {
            User = null;
            IsLoginUser = false;

            return true;
        }
    }
}
