﻿using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class ResultWorkoutsTest
    {
        [Fact]
        public void Get_All_ResultWorkouts()
        {
            var context = new TestsWodCatCloneContext();
            var expectedResultWorkouts = 1;
            var id = 1;

            var resultWorkouts = context.ResultWorkouts.Where(b => b.WorkoutId == id);
            Assert.NotNull(resultWorkouts);

            Assert.Equal(expectedResultWorkouts, resultWorkouts.Count());
        }

        [Fact]
        public void Get_ResultWorkout()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;

            var resultWorkout = context.ResultWorkouts.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(resultWorkout);

            Assert.Equal(id, resultWorkout.Id);
        }

        [Fact]
        public void Add_ResultWorkout()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newResultWorkout = new ResultWorkouts
            {
                Time = new TimeSpan(00, 20, 30),
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

            var addNewResultWorkout = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(addNewResultWorkout);

            context.ResultWorkouts.Remove(addNewResultWorkout);
            context.SaveChanges();

            var resultWorkoutAfterRemove = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.Null(resultWorkoutAfterRemove);

            userPoint += 10;
            user.Points += 10;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void Update_ResultWorkout()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newResultWorkout = new ResultWorkouts
            {
                Time = new TimeSpan(00, 20, 30),
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
                Time = new TimeSpan(00, 30, 20),
                Comment = "TestComment2",
                Repeat = 100,
                Fascination = 4,
                Load = 4,
                PublishDate = new DateTime(2003, 11, 15),
                WorkoutId = 2,
                UserId = user.Id
            };

            var resultWorkoutToUpdate = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(resultWorkoutToUpdate);

            resultWorkoutToUpdate.Time = editResultWorkout.Time;
            resultWorkoutToUpdate.Comment = editResultWorkout.Comment;
            resultWorkoutToUpdate.Repeat = editResultWorkout.Repeat;
            resultWorkoutToUpdate.Fascination = editResultWorkout.Fascination;
            resultWorkoutToUpdate.Load = editResultWorkout.Load;
            resultWorkoutToUpdate.PublishDate = editResultWorkout.PublishDate;

            context.SaveChanges();

            var resultWorkoutAfterUpdate = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(resultWorkoutAfterUpdate);

            context.ResultWorkouts.Remove(resultWorkoutAfterUpdate);
            context.SaveChanges();

            var resultWorkoutAfterUpdateRemove = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.Null(resultWorkoutAfterUpdateRemove);

            userPoint += 5;
            user.Points += 5;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void Remove_ResultWorkout()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newResultWorkout = new ResultWorkouts
            {
                Time = new TimeSpan(00, 20, 30),
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

            var resultWorkoutToRemove = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.NotNull(resultWorkoutToRemove);

            context.ResultWorkouts.Remove(resultWorkoutToRemove);
            context.SaveChanges();

            var resultWorkoutAfterRemove = context.ResultWorkouts.FirstOrDefault(b => b.Time == newResultWorkout.Time && b.Comment == newResultWorkout.Comment
            && b.Repeat == newResultWorkout.Repeat && b.Fascination == newResultWorkout.Fascination && b.Load == newResultWorkout.Load
            && b.PublishDate == newResultWorkout.PublishDate && b.WorkoutId == newResultWorkout.WorkoutId);

            Assert.Null(resultWorkoutAfterRemove);
        }

        private User HelperUserLogin(TestsWodCatCloneContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            return context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                     l.Password == login.Password);
        }
    }
}
