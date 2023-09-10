using Moq;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.AuthTests
{
    public class AuthTests
    {
        private readonly Mock<IAuthRepository> _repository;
        private readonly Mock<IUserRepository> _userRepository;

        public AuthTests()
        {
            _repository = new Mock<IAuthRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task Login()
        {
            var userModel = new User
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = new User
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

            _repository.Setup(_ => _.Login(userModel))
                .ReturnsAsync(user);

            IAuthService service = new AuthService(_repository.Object, _userRepository.Object);

            var result = await service.Login(userModel);

            _repository.Verify(_ => _.Login(userModel), 
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task Register()
        {
            var userModel = new User
            {
                Name = "Trevor2",
                Surname = "Philips2",
                NickName = "GTA52",
                Email = "trevor@gmail.com2",
                Password = "0000",
                Town = "Херсон",
                Birthday = new DateTime(2013, 09, 17),
                GenderId = 1,
            };

            var listUsers = new List<User>
            {
                new()
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
                },
                new()
                {
                    Id = 2,
                    Name = "Наташа",
                    Surname = "Возникова",
                    NickName = "Nat25",
                    Email = "nata@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 45,
                    Birthday = new DateTime(2000, 08, 29),
                    Height = "175",
                    Weight = "55",
                    AboutMe = "Test Nata",
                    GenderId = 2
                },
                new()
                {
                    Id = 3,
                    Name = "Trevor",
                    Surname = "Philips",
                    NickName = "GTA5",
                    Email = "trevor@gmail.com",
                    Password = "0000",
                    Country = "Ukraine",
                    Town = "Херсон",
                    Points = 180,
                    Birthday = new DateTime(2013, 09, 17),
                    Height = "190",
                    Weight = "80",
                    AboutMe = "I am crazy",
                    GenderId = 1,
                    ProgramId = 2,
                    HallId = 2
                }
            };

            _userRepository.Setup(_ => _.GetAllUsers())
                .ReturnsAsync(listUsers);

            _repository.Setup(_ => _.Register(userModel))
                .ReturnsAsync(true);

            IAuthService service = new AuthService(_repository.Object, _userRepository.Object);

            var result = await service.Register(userModel);

            _userRepository.Verify(_ => _.GetAllUsers(), 
                Times.Once);

            _repository.Verify(_ => _.Register(userModel), 
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task Logout()
        {
            IAuthService service = new AuthService(_repository.Object, _userRepository.Object);

            var result = await service.Logout();

            Assert.True(result);
        }
    }
}
