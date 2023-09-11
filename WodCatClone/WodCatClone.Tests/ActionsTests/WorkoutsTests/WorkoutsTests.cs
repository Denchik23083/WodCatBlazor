using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Tests.Utilities;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.ActionsTests.WorkoutsTests
{
    public class WorkoutsTests : AuthUser
    {
        private readonly Mock<IWorkoutsRepository> _repository;
        private readonly Mock<IUserRepository> _userRepository;

        public WorkoutsTests()
        {
            _repository = new Mock<IWorkoutsRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task GetAllWorkouts()
        {
            var workouts = new List<Workouts>
            {
                new()
                {
                    Id = 1,
                    Name = "100 Burpees",
                    Rating = "7.0",
                    Category = "Singlet,Bodyweight,For-Time",
                    Complexity = "Легкий",
                    Modality = "G",
                    Time = new TimeSpan(00, 23, 20),
                    HallId = 1
                },
                new()
                {
                    Id = 2,
                    Name = "1000",
                    Rating = "8.5",
                    Category = "Couplet,Bodyweight,For-Time",
                    Complexity = "Сложный",
                    Modality = "GM",
                    Time = new TimeSpan(00, 50, 30),
                    HallId = 4
                },
                new()
                {
                    Id = 3,
                    Name = "Titan wod",
                    Rating = "10.0",
                    Category = "Couplet,Bodyweight,ForTime,Rower",
                    Complexity = "Нормальный",
                    Modality = "GM",
                    Time = new TimeSpan(00, 24, 00),
                    HallId = 1
                },
                new()
                {
                    Id = 4,
                    Name = "Вместе Навсегда",
                    Rating = "8.0",
                    Category = "Couplet,ForTime,Kettlebell",
                    Complexity = "Нормальный",
                    Modality = "WM",
                    Time = new TimeSpan(00, 16, 25),
                    HallId = 2
                },
                new()
                {
                    Id = 5,
                    Name = "Jumping300",
                    Rating = "6.5",
                    Category = "Endurance,Singlet,AMRAP",
                    Complexity = "Легкий",
                    Modality = "M",
                    Time = new TimeSpan(00, 05, 00),
                    HallId = 4
                },
                new()
                {
                    Id = 6,
                    Name = "Siberian Bears",
                    Rating = "7.5",
                    Category = "Triplet,For-Time",
                    Complexity = "Нормальный",
                    Modality = "WGM",
                    Time = new TimeSpan(00, 19, 00),
                    HallId = 3
                },
                new()
                {
                    Id = 7,
                    Name = "08022014",
                    Rating = "8.0",
                    Category = "Couplet,For-Time",
                    Complexity = "Легкий",
                    Modality = "WG",
                    Time = new TimeSpan(00, 29, 06),
                    HallId = 5
                }
            };

            _repository.Setup(_ => _.GetAllWorkouts())
                .ReturnsAsync(workouts);

            IWorkoutsService service = new WorkoutsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllWorkouts();

            _repository.Verify(_ => _.GetAllWorkouts(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(workouts.Count, result.Count());
        }

        [Fact]
        public async Task GetWorkout()
        {
            var expectedId = 3;

            var workout = new Workouts
            {
                Id = expectedId,
                Name = "Titan wod",
                Rating = "10.0",
                Category = "Couplet,Bodyweight,ForTime,Rower",
                Complexity = "Нормальный",
                Modality = "GM",
                Time = new TimeSpan(00, 24, 00),
                HallId = 1
            };

            _repository.Setup(_ => _.GetWorkout(expectedId))
                .ReturnsAsync(workout);

            IWorkoutsService service = new WorkoutsService(_repository.Object, _userRepository.Object);

            var result = await service.GetWorkout(expectedId);

            _repository.Verify(_ => _.GetWorkout(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }

        [Fact]
        public async Task AddResultWorkouts()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var resultWorkoutsModel = new ResultWorkouts
            {
                Time = new TimeSpan(0, 20, 0),
                Comment = "newComment",
                Repeat = 20,
                Fascination = 4,
                Load = 5,
                WorkoutId = 3,
                PublishDate = DateTime.Now
            };

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.AddResultWorkouts(resultWorkoutsModel, user))
                .ReturnsAsync(true);

            IWorkoutsService service = new WorkoutsService(_repository.Object, _userRepository.Object);

            var result = await service.AddResultWorkouts(resultWorkoutsModel);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.AddResultWorkouts(resultWorkoutsModel, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task EditResultWorkouts()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var expectedId = 1;

            var resultWorkout = new ResultWorkouts
            {
                Id = expectedId,
                Time = new TimeSpan(0, 20, 0),
                Comment = "newComment",
                Repeat = 20,
                Fascination = 4,
                Load = 5,
                WorkoutId = 3,
                PublishDate = DateTime.Now
            };

            var resultWorkoutsModel = new ResultWorkouts
            {
                Time = new TimeSpan(0, 30, 0),
                Comment = "editComment",
                Repeat = 50,
                Fascination = 3,
                Load = 4,
                WorkoutId = 3,
                PublishDate = DateTime.Now
            };

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.GetResultWorkout(expectedId))
                .ReturnsAsync(resultWorkout);

            _repository.Setup(_ => _.EditResultWorkouts(resultWorkout, user))
                .ReturnsAsync(true);

            IWorkoutsService service = new WorkoutsService(_repository.Object, _userRepository.Object);

            var result = await service.EditResultWorkouts(resultWorkoutsModel, expectedId);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.GetResultWorkout(expectedId),
                Times.Once);

            _repository.Verify(_ => _.EditResultWorkouts(resultWorkout, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task RemoveResultWorkouts()
        {
            var expectedId = 1;

            var resultWorkout = new ResultWorkouts
            {
                Id = expectedId,
                Time = new TimeSpan(0, 20, 0),
                Comment = "newComment",
                Repeat = 20,
                Fascination = 4,
                Load = 5,
                WorkoutId = 3,
                PublishDate = DateTime.Now
            };

            _repository.Setup(_ => _.GetResultWorkout(expectedId))
                .ReturnsAsync(resultWorkout);

            _repository.Setup(_ => _.RemoveResultWorkouts(resultWorkout))
                .ReturnsAsync(true);

            IWorkoutsService service = new WorkoutsService(_repository.Object, _userRepository.Object);

            var result = await service.RemoveResultWorkouts(expectedId);

            _repository.Verify(_ => _.GetResultWorkout(expectedId),
                Times.Once);

            _repository.Verify(_ => _.RemoveResultWorkouts(resultWorkout),
                Times.Once);

            Assert.True(result);
        }
    }
}
