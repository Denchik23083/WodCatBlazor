using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class AuthUserTest
    {
        private static bool _isLoginUser;

        [Fact]
        public void Login()
        {
            var context = new TestsWodCatCloneContext();
            
            var user = HelperUserLogin(context);
            HelperIsLoginFunction(context);

            Assert.NotNull(user);
            Assert.True(_isLoginUser);
        }

        [Fact]
        public void Register()
        {
            var context = new TestsWodCatCloneContext();

            var register = new Register
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA573461736176312736",
                Email = "foo@gmail.com",
                Password = "0000",
                ConfirmPassword = "0000",
                GenderId = 1,
            };

            var registerUser = UserMap(register);

            registerUser.Country = "Ukraine";

            context.Users.Add(registerUser);
            context.SaveChanges();

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
        public void Logout()
        {
            _isLoginUser = false;

            Assert.False(_isLoginUser);
        }

        [Fact]
        public void Is_Login_User()
        {
            var context = new TestsWodCatCloneContext();

            HelperIsLoginFunction(context);

            Assert.True(_isLoginUser);
        }

        [Fact]
        public void Get_User()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);

            Assert.NotNull(user);
        }

        [Fact]
        public void Get_Gender()
        {
            var context = new TestsWodCatCloneContext();

            var loginUser = HelperUserLogin(context);

            var gender = context.Gender.FirstOrDefault(b => b.Id == loginUser.GenderId);

            Assert.NotNull(loginUser);
            Assert.NotNull(gender);
        }

        [Fact]
        public void Update_User()
        {
            var context = new TestsWodCatCloneContext();

            var genreName = "Мужской";

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA536127316273",
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
                NickName = "GTA5237126371263",
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
        public void Update_Auth()
        {
            var context = new TestsWodCatCloneContext();
            
            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA537263189382",
                Country = "Ukraine",
                Email = "foo3@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var newAuth = new User
            {
                NickName = "GTA52387283",
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
        public void Remove_User()
        {
            var context = new TestsWodCatCloneContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Country = "Ukraine",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA573874",
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

        private static void HelperIsLoginFunction(TestsWodCatCloneContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            _isLoginUser = user is not null;
        }

        private static User HelperUserLogin(TestsWodCatCloneContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            return context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                     l.Password == login.Password);
        }

        private static User UserMap(Register model)
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
