using Moq;
using WodCatClone.Core;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.UserTests
{
    public class UserTests
    {
        private readonly Mock<IUserRepository> _repository;
        private readonly Mock<IAuthRepository> _authRepository;

        public UserTests()
        {
            _repository = new Mock<IUserRepository>();
            _authRepository = new Mock<IAuthRepository>();
        }

        [Fact]
        public async Task GetAllUsers()
        {
            var users = new List<User>
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

            _repository.Setup(_ => _.GetAllUsers())
                .ReturnsAsync(users);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetAllUsers();

            _repository.Verify(_ => _.GetAllUsers(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(users.Count, result.Count());
        }

        [Fact]
        public async Task GetGenders()
        {
            var genders = new List<Gender>
            {
                new()
                {
                    Id = 1,
                    Type = GenderType.Male,
                    Image = "img/man.png"
                },
                new()
                {
                    Id = 2,
                    Type = GenderType.Female,
                    Image = "img/woman.png"
                }
            };

            _repository.Setup(_ => _.GetGenders())
                .ReturnsAsync(genders);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetGenders();

            _repository.Verify(_ => _.GetGenders(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(genders.Count, result.Count());
        }

        [Fact]
        public async Task IsLoginUser()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            IUserService userService = new UserService(_repository.Object);

            var userResult = await userService.IsLoginUser();

            Assert.True(userResult);
        }

        [Fact]
        public async Task GetUser()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var expectedId = 1;

            var user = User();

            _repository.Setup(_ => _.GetUser(expectedId))
                .ReturnsAsync(user);

            IUserService userService = new UserService(_repository.Object);

            var userResult = await userService.GetUser();

            _repository.Verify(_ => _.GetUser(expectedId),
                Times.Once);

            Assert.NotNull(userResult);
            Assert.Equal(expectedId, userResult!.Id);
        }

        [Fact]
        public async Task GetUserByNickName()
        {
            var expectedNickName = "SoEasyBlef";

            var user = User();

            _repository.Setup(_ => _.GetUser(expectedNickName))
                .ReturnsAsync(user);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetUser(expectedNickName);

            _repository.Verify(_ => _.GetUser(expectedNickName),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedNickName, result!.NickName);
        }
        
        [Fact]
        public async Task EditUserHall()
        {
            var hallId = 1;

            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            _repository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.EditUserHall(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.EditUserHall(user, hallId);

            _repository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.EditUserHall(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task Update()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var updateUser = new User
            {
                Name = "Hello",
                Surname = "Hello",
                Town = "Hello",
                GenderId = 1,
                Birthday = DateTime.Now.AddYears(-1),
                Height = "180",
                Weight = "80",
                AboutMe = "Hello"
            };

            var user = User();

            _repository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.Update(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.Update(updateUser, user.Id);

            _repository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.Update(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task UpdateAuth()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var updateUser = new User
            {
                NickName = "Foo",
                Email = "foo@gmail.com",
                Password = "0000"
            };

            var user = User();

            _repository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.Update(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.Update(updateUser, user.Id);

            _repository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.Update(user),
                Times.Once);

            Assert.True(result);
        }

        private async Task<bool> IsAuthUser()
        {
            var userModel = new User
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = User();

            _authRepository.Setup(_ => _.Login(userModel))
                .ReturnsAsync(user);

            IAuthService authService = new AuthService(_authRepository.Object, _repository.Object);

            var authResult = await authService.Login(userModel);

            _authRepository.Verify(_ => _.Login(userModel),
                Times.Once);

            return authResult;
        }

        private static User User()
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
