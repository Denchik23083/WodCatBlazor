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
        public void Get_All_Workouts()
        {
            var context = new TestsWodCatCloneContext();
            var expectedWorkouts = 7;

            var workouts = context.Workouts;
            Assert.NotNull(workouts);

            Assert.Equal(expectedWorkouts, workouts.Count());
        }

        [Fact]
        public void Get_All_WorkoutsExercises()
        {
            var context = new TestsWodCatCloneContext();
            var id = 2;
            var expectedWorkoutsExercises = 11;

            var workoutsExercises = context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
            Assert.NotNull(workoutsExercises);

            Assert.Equal(expectedWorkoutsExercises, workoutsExercises.Count());
        }

        [Fact]
        public void Get_Workout()
        {
            var context = new TestsWodCatCloneContext();
            var id = 2;

            var workout = context.Workouts.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(workout);

            Assert.Equal(id, workout.Id);
        }
    }
}
