using Moq;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Tests.Utilities
{
    public class AuthUser
    {
        private readonly Mock<IAuthRepository> _authRepository;
        private readonly Mock<IUserRepository> _userRepository;

        public AuthUser()
        {
            _authRepository = new Mock<IAuthRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        protected async Task<bool> IsAuthUser()
        {
            var userModel = new User
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = User();

            _authRepository.Setup(_ => _.LoginAsync(userModel))
                .ReturnsAsync(user);

            IAuthService authService = new AuthService(_authRepository.Object, _userRepository.Object);

            var authResult = await authService.LoginAsync(userModel);

            _authRepository.Verify(_ => _.LoginAsync(userModel),
                Times.Once);

            return authResult;
        }

        protected static User User()
        {
            return new User
            {
                Id = 1,
                Name = "Денис",
                Surname = "Кудрявов",
                NickName = "SoEasyBlef",
                Email = "deniskudravov228@gmail.com",
                Password = "0000",
                Country = "Ukraine",
                Town = "Херсон",
                Points = 200,
                Birthday = new DateTime(2003, 08, 23),
                Height = "185",
                Weight = "70",
                AboutMe = "I am a developer C#",
                GenderId = 1
            };
        }
    }
}
