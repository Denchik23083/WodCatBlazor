using System.Linq;
using WodCatClone.Db;
using Xunit;

namespace WodCatClone.Tests
{
    public class ExercisesTest
    {
        [Fact]
        public void GetAllExercisesTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var exercises = context.Exercises;

            Assert.NotNull(exercises);
            Assert.Equal(12, exercises.Count());
        }

        [Fact]
        public void GetExerciseTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var id = 2;
            var exercise = context.Exercises.FirstOrDefault(b => b.Id == id);

            Assert.NotNull(exercise);
            Assert.Equal(id, exercise.Id);
        }
    }
}
