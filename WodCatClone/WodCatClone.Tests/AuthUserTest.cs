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
            var registerUser = Map(register);

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

            Assert.NotNull(User);
        }

        [Fact]
        public void GetGenderTest()
        {
            var context = new TestsWodCatCloneDbContext();

            HelperLoginFunction(context);

            var gender = context.Gender.FirstOrDefault(b => b.Id == User.GenderId);

            Assert.NotNull(gender);
        }

        /*[Fact]
        public void EditUserHallTest()
        {

        }*/

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
                GenderId = model.GenderId
            };
        }
    }
}
