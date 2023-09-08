using Moq;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Tests.ActionsTests.WorkoutsTests
{
    public class WorkoutsTests
    {
        private readonly Mock<IWorkoutsRepository> _repository;

        public WorkoutsTests()
        {
            _repository = new Mock<IWorkoutsRepository>();
        }
    }
}
