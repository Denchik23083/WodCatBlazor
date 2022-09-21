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
            var user = _repository.Login(Map(login));

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
            return _repository.Register(Map(register));
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
