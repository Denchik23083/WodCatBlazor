using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class HallsTest
    {
        [Fact]
        public void GetAllHallsTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var expectedHalls = 5;

            var halls = context.Halls;
            Assert.NotNull(halls);

            Assert.Equal(expectedHalls, halls.Count());
        }

        [Fact]
        public void GetAllHallEmblemTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var expectedHallEmblem = 5;
            
            var hallEmblem = context.HallEmblem;
            Assert.NotNull(hallEmblem);

            Assert.Equal(expectedHallEmblem, hallEmblem.Count());
        }

        [Fact]
        public void GetAllHallsUsersTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;
            var countUser = 0;

            var countUsers = context.Users.Where(b => b.HallId == id);
            Assert.NotNull(countUsers);

            var hall = context.Halls.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(hall);
            Assert.Equal(id, hall.Id);

            Assert.Equal(countUser, countUsers.Count());
        }

        [Fact]
        public void GetHallTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;

            var hall = context.Halls.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(hall);

            hall.Type = hall.Type.Trim().Replace("\r", string.Empty);
            hall.Type = hall.Type.Trim().Replace("\n", string.Empty);
            hall.Type = hall.Type.Replace(Environment.NewLine, string.Empty);

            Assert.Equal(id, hall.Id);
        }

        [Fact]
        public void GetImageTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 3;
            var image = "img/EmblemHalls/Olimp.png";

            var hallEmblem = context.HallEmblem.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(hallEmblem);
            
            Assert.Equal(id, hallEmblem.Id);
            Assert.Equal(image, hallEmblem.Image);
        }

        [Fact]
        public void AddHallTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newHall = new Halls
            {
                Name = "TestName",
                Description = "TestDescription",
                Town = "TestTown",
                Location = "TestLocation",
                Rating = "8.5",
                Type = "TestType",
                UserId = user.Id,
                EmblemHallId = 3
            };

            context.Halls.Add(newHall);
            context.SaveChanges();

            var addNewHall = context.Halls.FirstOrDefault(b => b.Name == newHall.Name
            && b.Description == newHall.Description && b.Town == newHall.Town && b.Rating == newHall.Rating 
            && b.Location == newHall.Location && b.Type == newHall.Type);

            Assert.NotNull(addNewHall);

            context.Halls.Remove(addNewHall);
            context.SaveChanges();

            var hallAfterRemove = context.Halls.FirstOrDefault(b => b.Name == newHall.Name
            && b.Description == newHall.Description && b.Town == newHall.Town && b.Rating == newHall.Rating
            && b.Location == newHall.Location && b.Type == newHall.Type);

            Assert.Null(hallAfterRemove);

            userPoint += 50;
            user.Points += 50;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void UpdateHallTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newHall = new Halls
            {
                Name = "TestName",
                Description = "TestDescription",
                Town = "TestTown",
                Location = "TestLocation",
                Rating = "8.5",
                Type = "TestType",
                UserId = user.Id,
                EmblemHallId = 3
            };

            context.Halls.Add(newHall);
            context.SaveChanges();

            var editHall = new Halls
            {
                Name = "TestName",
                Description = "TestDescription",
                Town = "TestTown",
                Location = "TestLocation",
                Rating = "8.5",
                Type = "TestType",
                EmblemHallId = 3
            };

            var hallToUpdate = context.Halls.FirstOrDefault(b => b.Name == newHall.Name
            && b.Description == newHall.Description && b.Town == newHall.Town && b.Rating == newHall.Rating
            && b.Location == newHall.Location && b.Type == newHall.Type);

            Assert.NotNull(hallToUpdate);

            hallToUpdate.Name = editHall.Name;
            hallToUpdate.Description = editHall.Description;
            hallToUpdate.Town = editHall.Town;
            hallToUpdate.Location = editHall.Location;
            hallToUpdate.Rating = editHall.Rating;
            hallToUpdate.Type = editHall.Type;
            hallToUpdate.EmblemHallId = editHall.EmblemHallId;

            context.SaveChanges();

            var hallAfterUpdate = context.Halls.FirstOrDefault(b => b.Name == hallToUpdate.Name
            && b.Description == hallToUpdate.Description && b.Town == hallToUpdate.Town && b.Rating == hallToUpdate.Rating
            && b.Location == hallToUpdate.Location && b.Type == hallToUpdate.Type);

            Assert.NotNull(hallAfterUpdate);

            context.Halls.Remove(hallAfterUpdate);
            context.SaveChanges();

            var hallAfterUpdateRemove = context.Halls.FirstOrDefault(b => b.Name == hallToUpdate.Name
            && b.Description == hallToUpdate.Description && b.Town == hallToUpdate.Town && b.Rating == hallToUpdate.Rating
            && b.Location == hallToUpdate.Location && b.Type == hallToUpdate.Type);

            Assert.Null(hallAfterUpdateRemove);

            userPoint += 25;
            user.Points += 25;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void RemoveHallTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newHall = new Halls
            {
                Name = "TestName",
                Description = "TestDescription",
                Town = "TestTown",
                Location = "TestLocation",
                Rating = "8.5",
                Type = "TestType",
                UserId = user.Id,
                EmblemHallId = 3
            };

            context.Halls.Add(newHall);
            context.SaveChanges();
            
            var hallToRemove = context.Halls.FirstOrDefault(b => b.Name == newHall.Name
            && b.Description == newHall.Description && b.Town == newHall.Town && b.Rating == newHall.Rating
            && b.Location == newHall.Location && b.Type == newHall.Type);

            Assert.NotNull(hallToRemove);

            context.Halls.Remove(hallToRemove);
            context.SaveChanges();

            var hallAfterRemove = context.Halls.FirstOrDefault(b => b.Name == newHall.Name
            && b.Description == newHall.Description && b.Town == newHall.Town && b.Rating == newHall.Rating
            && b.Location == newHall.Location && b.Type == newHall.Type);

            Assert.Null(hallAfterRemove);
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
