using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class ProgramsTest
    {
        [Fact]
        public void GetAllProgramsTest()
        {
            var context = new TestsWodCatCloneContext();
            var expectedPrograms = 5;

            var programs = context.Programs;
            
            Assert.NotNull(programs);
            Assert.Equal(expectedPrograms, programs.Count());
        }

        [Fact]
        public void GetAllProgramsEmblemTest()
        {
            var context = new TestsWodCatCloneContext();
            var expectedProgramsEmblem = 5;

            var programsEmblem = context.ProgramEmblem;
            Assert.NotNull(programsEmblem);

            Assert.Equal(expectedProgramsEmblem, programsEmblem.Count());
        }

        [Fact]
        public void GetAllProgramsWorkoutsTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 2;
            var expectedProgramsWorkouts = 2;

            var programsWorkouts = context.ProgramsWorkouts.Where(p => p.ProgramsId == id);
            Assert.NotNull(programsWorkouts);
            
            foreach (var programsWorkout in programsWorkouts)
            {
                var workout = context.Workouts.Where(p => p.Id == programsWorkout.WorkoutsId);
                Assert.NotNull(workout);
            }

            Assert.Equal(expectedProgramsWorkouts, programsWorkouts.Count());
        }

        [Fact]
        public void GetAllProgramsUsersTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 2;
            var expectedUsers = 0;

            var program = context.Programs.FirstOrDefault(p => p.Id == id);
            Assert.NotNull(program);
            Assert.Equal(id, program.Id);

            var users = context.Users.Where(b => b.ProgramId == program.Id);
            Assert.NotNull(users);

            Assert.Equal(expectedUsers, users.Count());
        }

        [Fact]
        public void GetProgramTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;

            var program = context.Programs.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(program);

            Assert.Equal(id, program.Id);
        }

        [Fact]
        public void GetImageTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 3;
            var image = "img/EmblemPrograms/Men.png";

            var programEmblem = context.ProgramEmblem.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(programEmblem);

            Assert.Equal(id, programEmblem.Id);
            Assert.Equal(image, programEmblem.Image);
        }

        [Fact]
        public void BeginProgramTest()
        {
            var context = new TestsWodCatCloneContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo8@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);

            var newProgramId = 2;
            testUserEdit.ProgramId = newProgramId;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Equal(newProgramId, testUserAfterEdit.ProgramId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                        l.Password == testUserEdit.Password);
            Assert.Null(testUserAfterRemove);
        }

        [Fact]
        public void StopProgramTest()
        {
            var context = new TestsWodCatCloneContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo9@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);

            testUserEdit.ProgramId = null;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Null(testUserAfterEdit.ProgramId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserAfterEdit.Email &&
                                                                        l.Password == testUserAfterEdit.Password);
            Assert.Null(testUserAfterRemove);
        }
    }
}
