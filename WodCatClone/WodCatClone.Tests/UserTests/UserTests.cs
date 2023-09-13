using Moq;
using WodCatClone.Core;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Tests.Utilities;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.UserTests
{
    public class UserTests : AuthUser
    {
        private readonly Mock<IUserRepository> _repository;

        public UserTests()
        {
            _repository = new Mock<IUserRepository>();
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

            _repository.Setup(_ => _.GetAllUsersAsync())
                .ReturnsAsync(users);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetAllUsersAsync();

            _repository.Verify(_ => _.GetAllUsersAsync(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(users.Count, result.Count());
        }

        [Fact]
        public async Task GetAllGenders()
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

            _repository.Setup(_ => _.GetAllGendersAsync())
                .ReturnsAsync(genders);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetAllGendersAsync();

            _repository.Verify(_ => _.GetAllGendersAsync(),
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

            var userResult = await userService.IsLoginUserAsync();

            Assert.True(userResult);
        }

        [Fact]
        public async Task GetUser()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var expectedId = 1;            

            _repository.Setup(_ => _.GetUserAsync(expectedId))
                .ReturnsAsync(user);

            IUserService userService = new UserService(_repository.Object);

            var userResult = await userService.GetUserAsync();

            _repository.Verify(_ => _.GetUserAsync(expectedId),
                Times.Once);

            Assert.NotNull(userResult);
            Assert.Equal(expectedId, userResult!.Id);
        }

        [Fact]
        public async Task GetUserByNickName()
        {
            var user = User();

            var expectedNickName = "SoEasyBlef";

            _repository.Setup(_ => _.GetUserAsync(expectedNickName))
                .ReturnsAsync(user);

            IUserService service = new UserService(_repository.Object);

            var result = await service.GetUserAsync(expectedNickName);

            _repository.Verify(_ => _.GetUserAsync(expectedNickName),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedNickName, result!.NickName);
        }
        
        [Fact]
        public async Task EditUserHall()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var hallId = 1;

            _repository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.EditUserHallAsync(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.EditUserHallAsync(user, hallId);

            _repository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.EditUserHallAsync(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task Update()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

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

            _repository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.UpdateAsync(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.UpdateAsync(updateUser, user.Id);

            _repository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.UpdateAsync(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task UpdateAuth()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var updateUser = new User
            {
                NickName = "Foo",
                Email = "foo@gmail.com",
                Password = "0000"
            };           

            _repository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.UpdateAsync(user))
                .ReturnsAsync(true);

            IUserService service = new UserService(_repository.Object);

            var result = await service.UpdateAsync(updateUser, user.Id);

            _repository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.UpdateAsync(user),
                Times.Once);

            Assert.True(result);
        }
    }
}
