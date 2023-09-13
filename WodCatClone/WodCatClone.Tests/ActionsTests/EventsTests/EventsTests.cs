using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
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

            _repository.Setup(_ => _.GetAllEventsAsync())
                .ReturnsAsync(events);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEventsAsync();

            _repository.Verify(_ => _.GetAllEventsAsync(),
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

            _repository.Setup(_ => _.GetAllEndEventsAsync())
                .ReturnsAsync(endEvents);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEndEventsAsync();

            _repository.Verify(_ => _.GetAllEndEventsAsync(),
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

            _repository.Setup(_ => _.GetAllEventEmblemAsync())
                .ReturnsAsync(eventEmblem);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllEventEmblemAsync();

            _repository.Verify(_ => _.GetAllEventEmblemAsync(),
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

            _repository.Setup(_ => _.GetEventAsync(expectedId))
                .ReturnsAsync(@event);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.GetEventAsync(expectedId);

            _repository.Verify(_ => _.GetEventAsync(expectedId),
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

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.AddEventAsync(eventModel, user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.AddEventAsync(eventModel);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.AddEventAsync(eventModel, user),
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

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.GetEventAsync(expectedId))
                .ReturnsAsync(@event);

            _repository.Setup(_ => _.EditEventAsync(@event, user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.EditEventAsync(editModel, expectedId);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.GetEventAsync(expectedId),
                Times.Once);

            _repository.Verify(_ => _.EditEventAsync(@event, user),
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

            _repository.Setup(_ => _.GetEventAsync(expectedId))
                .ReturnsAsync(@event);

            _repository.Setup(_ => _.RemoveEventAsync(@event))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.RemoveEventAsync(expectedId);

            _repository.Verify(_ => _.GetEventAsync(expectedId),
                Times.Once);

            _repository.Verify(_ => _.RemoveEventAsync(@event),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task AutoRemoveEvent()
        {
            var expectedId = 1;

            var eventToRemove = new Events
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
            
            _repository.Setup(_ => _.AutoRemoveEventAsync(It.IsAny<IEnumerable<User>>(), eventToRemove))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.AutoRemoveEventAsync(eventToRemove);

            _repository.Verify(_ => _.AutoRemoveEventAsync(It.IsAny<IEnumerable<User>>(), eventToRemove),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task JoinEvent()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var eventId = 3;

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.JoinEventAsync(user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.JoinEventAsync(eventId, user);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.JoinEventAsync(user),
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

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.ExitEventAsync(user))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.ExitEventAsync(eventId, user);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.ExitEventAsync(user),
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

            _repository.Setup(_ => _.AddEventTimeUserAsync(eventTimeUser))
                .ReturnsAsync(true);

            IEventsService service = new EventsService(_repository.Object, _userRepository.Object);

            var result = await service.AddEventTimeUserAsync(eventTimeUser);

            _repository.Verify(_ => _.AddEventTimeUserAsync(eventTimeUser),
                Times.Once);

            Assert.True(result);
        }
    }
}
