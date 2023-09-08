using Moq;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;

namespace WodCatClone.Tests.ActionsTests.HallsTests
{
    public class HallsTests
    {
        private readonly Mock<IHallsRepository> _repository;

        public HallsTests()
        {
            _repository = new Mock<IHallsRepository>();
        }
    }
}
