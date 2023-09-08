using Moq;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;

namespace WodCatClone.Tests.ActionsTests.ProgramsTests
{
    public class ProgramsTests
    {
        private readonly Mock<IProgramsRepository> _repository;

        public ProgramsTests()
        {
            _repository = new Mock<IProgramsRepository>();
        }
    }
}
