using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly IUserRepository _userRepository;
        public static bool IsLoginUser;
        public static User? User;

        public AuthService(IAuthRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<bool> Login(User login)
        {
            var user = await _repository.Login(login);
            
            if (user is null)
            {
                return false;
            }

            User = user;
            IsLoginUser = true;

            return true;
        }

        public async Task<bool> Register(User register)
        {
            var allUsers = _userRepository.GetAllUsers();

            if (allUsers.Any(b => b.Email!.Equals(register.Email)
                                  || b.NickName!.Equals(register.NickName)))
            {
                return false;
            }

            register.Country = "Ukraine";

            return await _repository.Register(register);
        }

        public bool Logout()
        {
            User = null;
            IsLoginUser = false;

            return true;
        }
    }
}
