using System.Linq;
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
        public static User User;

        public AuthService(IAuthRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public bool Login(Login login)
        {
            var loginUser = Map(login);
            var user = _repository.Login(loginUser);

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
            var registerUser = Map(register);
            var allUsers = _userRepository.GetAllUsers();

            if (allUsers.Any(b => b.Email.Equals(registerUser.Email)
                                  || b.NickName.Equals(registerUser.NickName)))
            {
                return false;
            }

            return _repository.Register(registerUser);
        }

        public bool Logout()
        {
            User = null;
            IsLoginUser = false;

            return true;
        }

        private User Map(Login model)
        {
            return new User
            {
                Email = model.Email,
                Password = model.Password,
            };
        }

        private User Map(Register model)
        {
            return new User
            {
                Name = model.Name,
                Surname = model.Surname,
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password,
                Birthday = model.Birthday,
                GenderId = model.GenderId,
                Town = model.Town
            };
        }
    }
}
