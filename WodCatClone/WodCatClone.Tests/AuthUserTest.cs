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

        [Fact]
        public void LoginTest()
        {
            var context = new TestsWodCatCloneDbContext();
            
            var user = HelperUserLogin(context);
            HelperIsLoginFunction(context);

            Assert.NotNull(user);
            Assert.True(IsLoginUser);
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

            registerUser.Country = "Ukraine";

            if (register.Password == register.ConfirmPassword)
            {
                if (!allUsers.Any(b => b.Email == registerUser.Email) &&
                    !allUsers.Any(b => b.NickName == registerUser.NickName))
                {
                    context.Users.Add(registerUser);
                    context.SaveChanges();
                }
            }

            var all = context.Users;

            var registeredUser = context.Users.FirstOrDefault(l => l.Email == registerUser.Email &&
                                                                   l.Password == registerUser.Password);
            Assert.NotNull(registeredUser);
            Assert.True(register.Password == register.ConfirmPassword);

            context.Users.Remove(registeredUser);
            context.SaveChanges();

            var registeredUserRemove = context.Users.FirstOrDefault(l => l.Email == registerUser.Email &&
                                                                   l.Password == registerUser.Password);
            Assert.Null(registeredUserRemove);
        }

        [Fact]
        public void LogoutTest()
        {
            IsLoginUser = false;

            Assert.False(IsLoginUser);
        }

        [Fact]
        public void GetAllUsersTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var expectedUsers = 1;

            var users = context.Users;
            Assert.NotNull(users);

            Assert.Equal(expectedUsers, users.Count());
        }

        [Fact]
        public void IsLoginUserTest()
        {
            var context = new TestsWodCatCloneDbContext();

            HelperIsLoginFunction(context);

            Assert.True(IsLoginUser);
        }

        [Fact]
        public void GetUserTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);

            Assert.NotNull(user);
        }

        [Fact]
        public void GetGenderTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var loginUser = HelperUserLogin(context);

            var gender = context.Gender.FirstOrDefault(b => b.Id == loginUser.GenderId);

            Assert.NotNull(loginUser);
            Assert.NotNull(gender);
        }

        [Fact]
        public void UpdateTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var genreName = "�������";

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Email = "foo2@gmail.com",
                Password = "0000",
                Country = "Ukraine",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var editUser = new User
            {
                Name = "Michael2",
                Surname = "de Santa2",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA52",
                Email = "foo2@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            
            var genre = context.Gender.FirstOrDefault(b => b.Name == genreName);

            Assert.NotNull(testUserEdit);
            Assert.NotNull(genre);

            testUserEdit.Name = editUser.Name;
            testUserEdit.Surname = editUser.Surname;
            testUserEdit.Town = editUser.Town;
            testUserEdit.HallId = editUser.HallId;
            testUserEdit.Birthday = editUser.Birthday;
            testUserEdit.Height = editUser.Height;
            testUserEdit.Weight = editUser.Weight;
            testUserEdit.AboutMe = editUser.AboutMe;
            testUserEdit.GenderId = genre.Id;

            context.SaveChanges();

            Assert.Equal(testUserEdit.Name, editUser.Name);
            Assert.Equal(testUserEdit.Surname, editUser.Surname);
            Assert.Equal(testUserEdit.Town, editUser.Town);
            Assert.Equal(testUserEdit.HallId, editUser.HallId);
            Assert.Equal(testUserEdit.Birthday, editUser.Birthday);
            Assert.Equal(testUserEdit.Height, editUser.Height);
            Assert.Equal(testUserEdit.Weight, editUser.Weight);
            Assert.Equal(testUserEdit.AboutMe, editUser.AboutMe);
            Assert.Equal(testUserEdit.GenderId, genre.Id);

            context.Users.Remove(testUserEdit);
            context.SaveChanges();

            var testUserEditRemove = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                 l.Password == testUserEdit.Password);
            Assert.Null(testUserEditRemove);
        }

        [Fact]
        public void UpdateAuthTest()
        {
            var context = new TestsWodCatCloneDbContext();
            
            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo3@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var newAuth = new User
            {
                NickName = "GTA52",
                Email = "foo3@gmail.com",
                Password = "0000",
            };

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);

            Assert.NotNull(testUserEdit);

            testUserEdit.NickName = newAuth.NickName;
            testUserEdit.Email = newAuth.Email;
            testUserEdit.Password = newAuth.Password;

            context.SaveChanges();

            Assert.Equal(testUserEdit.NickName, newAuth.NickName);
            Assert.Equal(testUserEdit.Email, newAuth.Email);
            Assert.Equal(testUserEdit.Password, newAuth.Password);

            context.Users.Remove(testUserEdit);
            context.SaveChanges();

            var testUserEditRemove = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                       l.Password == testUserEdit.Password);
            Assert.Null(testUserEditRemove);
        }

        [Fact]
        public void RemoveTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Country = "Ukraine",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Email = "foo4@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserRemove = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserRemove);

            context.Users.Remove(testUserRemove);
            context.SaveChanges();

            var testUserRemoved = context.Users.FirstOrDefault(l => l.Email == testUserRemove.Email &&
                                                                 l.Password == testUserRemove.Password);
            Assert.Null(testUserRemoved);
        }

        [Fact]
        public void JoinTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo5@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);

            var newHallId = 2;
            testUserEdit.HallId = newHallId;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                 l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Equal(newHallId, testUserAfterEdit.HallId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.Null(testUserAfterRemove);
        }

        [Fact]
        public void ExitTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var newUser = new User
            {
                Name = "Michael2",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo6@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);
            
            testUserEdit.HallId = null;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Null(testUserAfterEdit.HallId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserAfterEdit.Email &&
                                                                        l.Password == testUserAfterEdit.Password);
            Assert.Null(testUserAfterRemove);
        }

        private void HelperIsLoginFunction(TestsWodCatCloneDbContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            IsLoginUser = user is not null;
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
