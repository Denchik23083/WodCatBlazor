using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class WorkoutsTest
    {
        [Fact]
        public void GetAllWorkoutsTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var workouts = context.Workouts;
            Assert.NotNull(workouts);

            Assert.Equal(3, workouts.Count());
        }

        [Fact]
        public void GetWorkoutTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 2;

            var workout = context.Workouts.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(workout);

            Assert.Equal(id, workout.Id);
        }

        [Fact]
        public void GetImageTest()
        {
            var context = new TestsWodCatCloneDbContext();
            var id = 3;
            var image = "img/EmblemHalls/Olimp.png";

            var workoutEmblem = context.HallEmblem.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(workoutEmblem);

            Assert.Equal(id, workoutEmblem.Id);
            Assert.Equal(image, workoutEmblem.Image);
        }

        [Fact]
        public void GetAllResultWorkoutsTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var resultWorkouts = context.ResultWorkouts;
            Assert.NotNull(resultWorkouts);

            Assert.Equal(0, resultWorkouts.Count());
        }

        [Fact]
        public void GetCountResultWorkoutsTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var resultWorkouts = context.ResultWorkouts.Count();
            Assert.Equal(0, resultWorkouts);
        }

        [Fact]
        public void AddResultWorkoutTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newResultWorkout = new ResultWorkouts
            {
                Minutes = "20",
                Seconds = "30",
                Comment = "TestComment",
                Repeat = 200,
                Fascination = 5,
                Load = 5,
                PublishDate = new DateTime(2000, 12, 12),
                WorkoutId = 2,
                UserId = user.Id
            };

            context.ResultWorkouts.Add(newResultWorkout);
            context.SaveChanges();

            var addNewResultWorkout = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(addNewResultWorkout);

            context.ResultWorkouts.Remove(addNewResultWorkout);
            context.SaveChanges();

            var resultWorkoutAfterRemove = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.Null(resultWorkoutAfterRemove);

            userPoint += 10;
            user.Points += 10;
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

            var newResultWorkout = new ResultWorkouts
            {
                Minutes = "20",
                Seconds = "30",
                Comment = "TestComment",
                Repeat = 200,
                Fascination = 5,
                Load = 5,
                PublishDate = new DateTime(2000, 12, 12),
                WorkoutId = 2,
                UserId = user.Id
            };

            context.ResultWorkouts.Add(newResultWorkout);
            context.SaveChanges();

            var editResultWorkout = new ResultWorkouts
            {
                Minutes = "30",
                Seconds = "20",
                Comment = "TestComment2",
                Repeat = 100,
                Fascination = 4,
                Load = 4,
                PublishDate = new DateTime(2003, 11, 15),
                WorkoutId = 2,
                UserId = user.Id
            };

            var resultWorkoutToUpdate = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(resultWorkoutToUpdate);

            resultWorkoutToUpdate.Minutes = editResultWorkout.Minutes;
            resultWorkoutToUpdate.Seconds = editResultWorkout.Seconds;
            resultWorkoutToUpdate.Comment = editResultWorkout.Comment;
            resultWorkoutToUpdate.Repeat = editResultWorkout.Repeat;
            resultWorkoutToUpdate.Fascination = editResultWorkout.Fascination;
            resultWorkoutToUpdate.Load = editResultWorkout.Load;
            resultWorkoutToUpdate.PublishDate = editResultWorkout.PublishDate;

            context.SaveChanges();

            var resultWorkoutAfterUpdate = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(resultWorkoutAfterUpdate);

            context.ResultWorkouts.Remove(resultWorkoutAfterUpdate);
            context.SaveChanges();

            var resultWorkoutAfterUpdateRemove = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);
            
            Assert.Null(resultWorkoutAfterUpdateRemove);

            userPoint += 5;
            user.Points += 5;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void RemoveArticleTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newResultWorkout = new ResultWorkouts
            {
                Minutes = "20",
                Seconds = "30",
                Comment = "TestComment",
                Repeat = 200,
                Fascination = 5,
                Load = 5,
                PublishDate = new DateTime(2000, 12, 12),
                WorkoutId = 2,
                UserId = user.Id
            };

            context.ResultWorkouts.Add(newResultWorkout);
            context.SaveChanges();

            var resultWorkoutToRemove = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);
            
            Assert.NotNull(resultWorkoutToRemove);

            context.ResultWorkouts.Remove(resultWorkoutToRemove);
            context.SaveChanges();

            var resultWorkoutAfterRemove = context.ResultWorkouts.FirstOrDefault(b => b.Minutes == newResultWorkout.Minutes && b.Seconds == newResultWorkout.Seconds
            && b.Comment == newResultWorkout.Comment && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);
            
            Assert.Null(resultWorkoutAfterRemove);
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
