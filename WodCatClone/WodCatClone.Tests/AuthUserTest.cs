using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class AuthUserTest
    {
        public static bool IsLoginUser;
        public static User User;
        public static int CountUser;
        public static User TestUser;

        [Fact]
        public void LoginTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);

            Assert.True(IsLoginUser);
            Assert.NotNull(User);
        }

        [Fact]
        public void RegisterTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var register = new Register
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Email = "foo@gmail.com",
                Password = "0000",
                ConfirmPassword = "0000",
                GenderId = 1,
            };
            
            var allUsers = context.Users;
            var registerUser = UserMap(register);

            CountUser = allUsers.Count();

            registerUser.Country = "Ukraine";

            if (register.Password == register.ConfirmPassword)
            {
                if (!allUsers.Any(b => b.Email == registerUser.Email) &&
                    !allUsers.Any(b => b.NickName == registerUser.NickName))
                {
                    context.Users.Add(registerUser);
                    context.SaveChanges();

                    CountUser += 1;
                }
            }

            var registeredUser = context.Users.FirstOrDefault(l => l.Email == registerUser.Email &&
                                                                   l.Password == registerUser.Password);

            TestUser = registeredUser;

            Assert.NotNull(registeredUser);
            Assert.Equal(CountUser, allUsers.Count());
            Assert.True(register.Password == register.ConfirmPassword);
        }

        [Fact]
        public void LogoutTest()
        {
            User = null;
            IsLoginUser = false;

            Assert.Null(User);
            Assert.False(IsLoginUser);
        }

        [Fact]
        public void GetAllUsersTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var users = context.Users.Count();

            Assert.Equal(CountUser, users);
        }

        [Fact]
        public void IsLoginUserTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);

            Assert.True(IsLoginUser);
        }

        [Fact]
        public void GetUserTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);

            var user = HelperUserLogin(context);

            Assert.NotNull(User);
            Assert.NotNull(user);
        }

        [Fact]
        public void GetGenderTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);

            var loginUser = HelperUserLogin(context);

            var gender = context.Gender.FirstOrDefault(b => b.Id == loginUser.GenderId);

            Assert.NotNull(loginUser);
            Assert.NotNull(gender);
        }

        [Fact]
        public void EditUserHallTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);

            var newHallId = 2;
            User.HallId = newHallId;

            var loginUser = HelperUserLogin(context);
            loginUser.HallId = newHallId;

            context.SaveChanges();

            Assert.NotNull(loginUser);
            Assert.Equal(newHallId, User.HallId);
            Assert.Equal(newHallId, loginUser.HallId);
        }

        [Fact]
        public void UpdateTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var genreName = "Мужской";

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Email = "foo@gmail.com",
                Password = "0000",
                HallId = 1,
            };

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == TestUser.Email &&
                                                                 l.Password == TestUser.Password);
            var genre = context.Gender.FirstOrDefault(b => b.Name == genreName);

            Assert.NotNull(testUserEdit);
            Assert.NotNull(genre);

            testUserEdit.Name = newUser.Name;
            testUserEdit.Surname = newUser.Surname;
            testUserEdit.Town = newUser.Town;
            testUserEdit.HallId = newUser.HallId;
            testUserEdit.Birthday = newUser.Birthday;
            testUserEdit.Height = newUser.Height;
            testUserEdit.Weight = newUser.Weight;
            testUserEdit.AboutMe = newUser.AboutMe;
            testUserEdit.GenderId = genre.Id;

            context.SaveChanges();

            Assert.Equal(testUserEdit.Name, newUser.Name);
            Assert.Equal(testUserEdit.Surname, newUser.Surname);
            Assert.Equal(testUserEdit.Town, newUser.Town);
            Assert.Equal(testUserEdit.HallId, newUser.HallId);
            Assert.Equal(testUserEdit.Birthday, newUser.Birthday);
            Assert.Equal(testUserEdit.Height, newUser.Height);
            Assert.Equal(testUserEdit.Weight, newUser.Weight);
            Assert.Equal(testUserEdit.AboutMe, newUser.AboutMe);
            Assert.Equal(testUserEdit.GenderId, genre.Id);
        }

        [Fact]
        public void UpdateAuthTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var allUsers = context.Users;
            
            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == TestUser.Email &&
                                                                 l.Password == TestUser.Password);

            Assert.NotNull(testUserEdit);

            var newAuth = new User
            {
                NickName = "GTA5",
                Email = "foo@gmail.com",
                Password = "0000",
            };

            if (!allUsers.Any(b => b.Email == newAuth.Email) &&
                !allUsers.Any(b => b.NickName == newAuth.NickName))
            {
                testUserEdit.NickName = newAuth.NickName;
                testUserEdit.Email = newAuth.Email;
                testUserEdit.Password = newAuth.Password;

                context.SaveChanges();
            }

            TestUser.NickName = newAuth.NickName;
            TestUser.Email = newAuth.Email;
            TestUser.Password = newAuth.Password;

            Assert.Equal(testUserEdit.NickName, newAuth.NickName);
            Assert.Equal(testUserEdit.Email, newAuth.Email);
            Assert.Equal(testUserEdit.Password, newAuth.Password);
        }

        [Fact]
        public void RemoveTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var allUsers = context.Users;

            var removedUser = UserForRemove(context);

            Assert.NotNull(removedUser);

            context.Users.Remove(removedUser);

            context.SaveChanges();

            CountUser -= 1;

            Assert.Equal(CountUser, allUsers.Count());
        }
        
        private void HelperLoginFunction(TestsWodCatCloneDbContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            if (user is null)
            {
                IsLoginUser = false;
                User = null;
            }
            else
            {
                IsLoginUser = true;
                User = user;
            }
        }

        private User HelperUserLogin(TestsWodCatCloneDbContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            return user;
        }

        private User UserForRemove(TestsWodCatCloneDbContext context)
        {
            var allUsers = context.Users;
            CountUser = allUsers.Count();

            var testUser = new User
            {
                Name = "",
                Surname = "",
                Town = "",
                HallId = 1,
                Birthday = new DateTime(),
                Height = "",
                Weight = "",
                AboutMe = "",
                NickName = "NewNickName",
                Email = "newEmail@gmail.com",
                Password = "1111",
                GenderId = 1
            };

            context.Users.Add(testUser);
            context.SaveChanges();

            CountUser += 1;

            TestUser = testUser;

            return testUser;
        }

        private User UserMap(Register model)
        {
            return new User
            {
                Name = model.Name,
                Surname = model.Surname,
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password,
                Birthday = model.Birthday,
                GenderId = model.GenderId
            };
        }
    }
}
