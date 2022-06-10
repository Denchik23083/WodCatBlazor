using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class ProgramsTest
    {
        public static bool IsLoginUser;
        public static User User;

        [Fact]
        public void GetAllProgramsTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var programs = context.Programs;
            
            Assert.NotNull(programs);
            Assert.Equal(3, programs.Count());
        }

        [Fact]
        public void GetAllProgramsWorkoutsTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;

            var programsWorkouts = context.ProgramsWorkouts.Where(p => p.ProgramsId == id);
            Assert.NotNull(programsWorkouts);
            
            foreach (var programsWorkout in programsWorkouts)
            {
                var workout = context.Workouts.Where(p => p.Id == programsWorkout.WorkoutsId);
                Assert.NotNull(workout);
            }

            Assert.Equal(2, programsWorkouts.Count());
        }

        [Fact]
        public void GetAllProgramsUsersTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;

            var program = context.Programs.FirstOrDefault(p => p.Id == id);
            Assert.NotNull(program);

            var countUser = program.CountUser;

            var users = context.Users.Where(b => b.ProgramsId == id);
            
            Assert.Equal(countUser, users.Count());
        }

        [Fact]
        public void GetProgramTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 1;

            var program = context.Programs.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(program);

            Assert.Equal(id, program.Id);
        }

        [Fact]
        public void BeginProgramTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);
            Assert.NotNull(User);

            var id = 2;
            var program = context.Programs.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(program);

            User.ProgramsId = id;
            Assert.Equal(id, User.ProgramsId);

            var loginUser = HelperUserLogin(context);
            Assert.NotNull(loginUser);

            loginUser.ProgramsId = id;
            context.SaveChanges();

            Assert.Equal(id, loginUser.ProgramsId);

            program.CountUser += 1;

            context.SaveChanges();
        }

        [Fact]
        public void StopProgramTest()
        {
            var context = new TestsWodCatCloneDbContext();
            HelperLoginFunction(context);
            Assert.NotNull(User);

            var id = 2;
            var program = context.Programs.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(program);

            User.ProgramsId = null;
            Assert.Null(User.ProgramsId);

            var loginUser = HelperUserLogin(context);
            Assert.NotNull(loginUser);

            loginUser.ProgramsId = null;
            context.SaveChanges();

            Assert.Null(loginUser.ProgramsId);

            program.CountUser -= 1;
            context.SaveChanges();
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
    }
}
