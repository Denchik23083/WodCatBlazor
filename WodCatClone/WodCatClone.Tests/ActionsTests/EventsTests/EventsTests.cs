using Microsoft.Extensions.Logging;
using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Tests.Utilities;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.ActionsTests.EventsTests
{
    public class EventsTests : AuthUser
    {
        private readonly Mock<IEventsRepository> _repository;
        private readonly Mock<IUserRepository> _userRepository;

        public EventsTests()
        {
            _repository = new Mock<IEventsRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task GetAllEvents()
        {
            var events = new List<Events>
            {
                new()
                {
                    Id = 1,
                    Name = "Event",
                    Town = "Киев",
                    Location = "Location",
                    EventsEmblemId = 3,
                    HallId = 3,
                    TypeEvent = "TypeEvent",
                    TypeSport = "TypeSport",
                    StartDate = new DateTime(2023, 12, 20),
                    EndDate = new DateTime(2023, 12, 21),
                    RegisterDate = new DateTime(2023, 12, 19),
                    UserId = 1,
                    WorkoutId = 6,
                    Description = "Description"
                }
            };

            _repository.Setup(_ => _.GetAllEvents())
                .ReturnsAsync(events);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEvents();

            _repository.Verify(_ => _.GetAllEvents(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(events.Count, result.Count());
        }

        [Fact]
        public async Task GetAllEndEvents()
        {
            var endEvents = new List<Events>
            {
                new()
                {
                    Id = 2,
                    Name = "EndEvent",
                    Town = "Херсон",
                    Location = "Location",
                    EventsEmblemId = 2,
                    HallId = 2,
                    TypeEvent = "TypeEvent",
                    TypeSport = "TypeSport",
                    StartDate = new DateTime(2023, 08, 20),
                    EndDate = new DateTime(2023, 08, 21),
                    RegisterDate = new DateTime(2023, 08, 19),
                    UserId = 1,
                    WorkoutId = 4,
                    Description = "Description"
                }
            };

            _repository.Setup(_ => _.GetAllEndEvents())
                .ReturnsAsync(endEvents);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEndEvents();

            _repository.Verify(_ => _.GetAllEndEvents(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(endEvents.Count, result.Count());
        }

        [Fact]
        public async Task GetAllEventEmblem()
        {
            var eventEmblem = new List<EventEmblem>
            {
                new() { Id = 1, Name = "Fon", Image = "img/EmblemEvents/fon.jpg" },
                new() { Id = 2, Name = "Idi", Image = "img/EmblemEvents/idi.jpg" },
                new() { Id = 3, Name = "Lime", Image = "img/EmblemEvents/lime.jpg" },
                new() { Id = 4, Name = "Run", Image = "img/EmblemEvents/run.jpg" },
                new() { Id = 5, Name = "Sport", Image = "img/EmblemEvents/sport.jpg" }
            };

            _repository.Setup(_ => _.GetAllEventEmblem())
                .ReturnsAsync(eventEmblem);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEventEmblem();

            _repository.Verify(_ => _.GetAllEventEmblem(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(eventEmblem.Count, result.Count());
        }

        [Fact]
        public async Task GetEvent()
        {
            var expectedId = 1;

            var @event = new Events
            {
                Id = expectedId,
                Name = "Event",
                Town = "Киев",
                Location = "Location",
                EventsEmblemId = 3,
                HallId = 3,
                TypeEvent = "TypeEvent",
                TypeSport = "TypeSport",
                StartDate = new DateTime(2023, 12, 20),
                EndDate = new DateTime(2023, 12, 21),
                RegisterDate = new DateTime(2023, 12, 19),
                UserId = 1,
                WorkoutId = 6,
                Description = "Description"
            };

            _repository.Setup(_ => _.GetEvent(expectedId))
                .ReturnsAsync(@event);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetEvent(expectedId);

            _repository.Verify(_ => _.GetEvent(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }

        [Fact]
        public async Task AddEvent()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var eventModel = new Events
            {
                Name = "newEvent",
                Town = "Киев",
                Location = "Location",
                EventsEmblemId = 3,
                HallId = 3,
                TypeEvent = "TypeEvent",
                TypeSport = "TypeSport",
                StartDate = new DateTime(2023, 12, 20),
                EndDate = new DateTime(2023, 12, 21),
                RegisterDate = new DateTime(2023, 12, 19),
                WorkoutId = 6,
                Description = "Description"
            };

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.AddEvent(eventModel, user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.AddEvent(eventModel);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.AddEvent(eventModel, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task EditEvent()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var expectedId = 1;

            var @event = new Events
            {
                Id = expectedId,
                Name = "Event",
                Town = "Киев",
                Location = "Location",
                EventsEmblemId = 3,
                HallId = 3,
                TypeEvent = "TypeEvent",
                TypeSport = "TypeSport",
                StartDate = new DateTime(2023, 12, 20),
                EndDate = new DateTime(2023, 12, 21),
                RegisterDate = new DateTime(2023, 12, 19),
                UserId = 1,
                WorkoutId = 6,
                Description = "Description"
            };

            var editModel = new Events
            {
                Name = "editEvent",
                Town = "Киев",
                Location = "Location",
                EventsEmblemId = 3,
                HallId = 3,
                TypeEvent = "TypeEvent",
                TypeSport = "TypeSport",
                StartDate = new DateTime(2023, 12, 20),
                EndDate = new DateTime(2023, 12, 21),
                RegisterDate = new DateTime(2023, 12, 19),
                WorkoutId = 6,
                Description = "Description"
            };

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.GetEvent(expectedId))
                .ReturnsAsync(@event);

            _repository.Setup(_ => _.EditEvent(@event, user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.EditEvent(editModel, expectedId);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.GetEvent(expectedId),
                Times.Once);

            _repository.Verify(_ => _.EditEvent(@event, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task RemoveEvent()
        {
            var expectedId = 1;

            var @event = new Events
            {
                Id = expectedId,
                Name = "Event",
                Town = "Киев",
                Location = "Location",
                EventsEmblemId = 3,
                HallId = 3,
                TypeEvent = "TypeEvent",
                TypeSport = "TypeSport",
                StartDate = new DateTime(2023, 12, 20),
                EndDate = new DateTime(2023, 12, 21),
                RegisterDate = new DateTime(2023, 12, 19),
                UserId = 1,
                WorkoutId = 6,
                Description = "Description"
            };

            _repository.Setup(_ => _.GetEvent(expectedId))
                .ReturnsAsync(@event);

            _repository.Setup(_ => _.RemoveEvent(@event))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.RemoveEvent(expectedId);

            _repository.Verify(_ => _.GetEvent(expectedId),
                Times.Once);

            _repository.Verify(_ => _.RemoveEvent(@event),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public void AutoRemoveEvent()
        {
            Assert.Equal(1, 2);
        }

        [Fact]
        public async Task JoinEvent()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var eventId = 3;

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.JoinEvent(user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.JoinEvent(eventId, user);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.JoinEvent(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task ExitEvent()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var eventId = 3;

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.ExitEvent(user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.ExitEvent(eventId, user);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.ExitEvent(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task AddEventTimeUser()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var eventTimeUser = new EventTimeUser
            {
                Time = new TimeSpan(0, 30, 0),
                EventsId = 1,
                UserId = user.Id
            };

            _repository.Setup(_ => _.AddEventTimeUser(eventTimeUser))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.AddEventTimeUser(eventTimeUser);

            _repository.Verify(_ => _.AddEventTimeUser(eventTimeUser),
                Times.Once);

            Assert.True(result);
        }
    }
}
