using Moq;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;

namespace WodCatClone.Tests.ActionsTests.ExercisesTests
{
    public class ExercisesTests
    {
        private readonly Mock<IExercisesRepository> _repository;

        public ExercisesTests()
        {
            _repository = new Mock<IExercisesRepository>();
        }
    }
}
