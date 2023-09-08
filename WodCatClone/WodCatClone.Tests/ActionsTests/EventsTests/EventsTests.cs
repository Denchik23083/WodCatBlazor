using Moq;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;

namespace WodCatClone.Tests.ActionsTests.EventsTests
{
    public class EventsTests
    {
        private readonly Mock<IEventsRepository> _repository;

        public EventsTests()
        {
            _repository = new Mock<IEventsRepository>();
        }
    }
}
