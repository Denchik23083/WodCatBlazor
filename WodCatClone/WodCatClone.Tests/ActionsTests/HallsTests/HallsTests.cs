using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Tests.Utilities;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.ActionsTests.HallsTests
{
    public class HallsTests : AuthUser
    {
        private readonly Mock<IHallsRepository> _repository;
        private readonly Mock<IUserRepository> _userRepository;

        public HallsTests()
        {
            _repository = new Mock<IHallsRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task GetAllHalls()
        {
            var halls = new List<Halls>
            {
                new()
                {
                    Id = 1,
                    Name = "DOG & GRAND CROSSFIT",
                    Type = "Affiliate Crossfit,Boxing,Fitness,Gym,MMA,Yoga",
                    Town = "Киев",
                    Location = "Днепровская набережная, 14К",
                    Description = "DOG – первый фитнес клуб Киева, который получил официальную CrossFit сертификацию. Высокие стандарты обслуживания, качества оборудования и подхода к тренировкам обязательны для получения сертификации.Титулованный тренерский состав и профессиональное оборудование сделают ваши занятия более эффективными и помогут выйти на новый уровень физической подготовки.Главные тренера клубов ДОГ - Валентин Литвинчук и Леонид Леус - настоящие профессионалы которые стоят у истоков развития Кроссфита в Украине Более 50 различных & nb...",
                    EmblemHallId = 1
                },
                new()
                {
                    Id = 2,
                    Name = "M4",
                    Type = "Crossfit (not Aff.)",
                    Town = "Харьков",
                    Location = "пр. Тракторостроителей 57б",
                    Rating = "10.0",
                    EmblemHallId = 2
                },
                new()
                {
                    Id = 3,
                    Name = "Олимп",
                    Type = "Crossfit (not Aff.),Fitness,Gym,Yoga",
                    Description = "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.",
                    Town = "Львов",
                    Rating = "10.0",
                    EmblemHallId = 3
                },
                new()
                {
                    Id = 4,
                    Name = "Crossfit Banda",
                    Type = "Affiliate Crossfit,Fitness,Gym,Weightlifting,Yoga",
                    Description = "Первая сеть кроссфит-залов в Киеве - 4 зала в разных районах города и локации для бесплатных тренировок. Самый большой из них - площадью в 1200 кв.м. Сертифицированные тренера.Физическая реабилитация после травм.Команда Banda Crossfit принимает участие в благотворительном забеге Wings for Life World Run.Клуб проводит все украинские турниры по кроссфиту Banda Arena Challenge.Скретчинг, настольный теннис для отдыха.Школа тренеров, семинары, собственная лаборатория Banda Lab.Множество мероприятий и партнёров.",
                    Rating = "5.0",
                    Town = "Киев",
                    Location = "Новопечерский переулок, 5",
                    EmblemHallId = 5
                },
                new()
                {
                    Id = 5,
                    Name = "BLaS CrossFit Area",
                    Type = "Affiliate Crossfit,Fitness,Gym",
                    Description = "Blas (CrossFit — BLaS CA! BLaS = Body Like a Stone) Crossfit Area, Днепр. Целый спортивный комплекс на берегу Днепра - 300 кв.м. Единственный аффилированный зал в городе.Персональные тренировки по всем направлениям, в том числе Crossfit Kids.Отличная команда тренеров.Профессиональное оборудование Rogue(3 тонны железа), кроссфит - рама, 2 Air Bikes, 10 гребных тренажёров Concept.Массажный кабинет, фитнес - бар с самыми лучшими коктейлями, детская комната, если негде оставить ребенка.",
                    Town = "Днепр",
                    Location = "улица Набережная Победы, 62",
                    EmblemHallId = 4
                }
            };

            _repository.Setup(_ => _.GetAllHallsAsync())
                .ReturnsAsync(halls);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllHallsAsync();

            _repository.Verify(_ => _.GetAllHallsAsync(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(halls.Count, result.Count());
        }

        [Fact]
        public async Task GetAllHallEmblem()
        {
            var hallEmblem = new List<HallEmblem>
            {
                new() { Id = 1, Name = "Dog", Image = "img/EmblemHalls/Dog.png" },
                new() { Id = 2, Name = "M4", Image = "img/EmblemHalls/M4.png" },
                new() { Id = 3, Name = "Olimp", Image = "img/EmblemHalls/Olimp.png" },
                new() { Id = 4, Name = "BlasArea", Image = "img/EmblemHalls/BlasArea.png" },
                new() { Id = 5, Name = "Banda", Image = "img/EmblemHalls/Banda.png" }
            };

            _repository.Setup(_ => _.GetAllHallEmblemAsync())
                .ReturnsAsync(hallEmblem);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllHallEmblemAsync();

            _repository.Verify(_ => _.GetAllHallEmblemAsync(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(hallEmblem.Count, result.Count());
        }

        [Fact]
        public async Task GetHall()
        {
            var expectedId = 3;

            var hall = new Halls
            {
                Id = expectedId,
                Name = "Олимп",
                Type = "Crossfit (not Aff.),Fitness,Gym,Yoga",
                Description = "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.",
                Town = "Львов",
                Rating = "10.0",
                EmblemHallId = 3
            };

            _repository.Setup(_ => _.GetHallAsync(expectedId))
                .ReturnsAsync(hall);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.GetHallAsync(expectedId);

            _repository.Verify(_ => _.GetHallAsync(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }

        [Fact]
        public async Task AddHall()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var hallModel = new Halls
            {
                Name = "newHall",
                Type = "newType",
                Rating = "9.5",
                Description = "newDescription",
                Location = "newLocation",
                Town = "newTown",
                EmblemHallId = 3,                
                UserId = user.Id
            };

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.AddHallAsync(hallModel, user))
                .ReturnsAsync(true);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.AddHallAsync(hallModel);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.AddHallAsync(hallModel, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task EditHall()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var expectedId = 3;

            var hall = new Halls
            {
                Id = expectedId,
                Name = "Олимп",
                Type = "Crossfit (not Aff.),Fitness,Gym,Yoga",
                Description = "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.",
                Town = "Львов",
                Rating = "10.0",
                EmblemHallId = 3
            };

            var hallModel = new Halls
            {
                Name = "newHall",
                Type = "newType",
                Rating = "9.5",
                Description = "newDescription",
                Location = "newLocation",
                Town = "newTown",
                EmblemHallId = 3,
            };

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.GetHallAsync(expectedId))
                .ReturnsAsync(hall);

            _repository.Setup(_ => _.EditHallAsync(hall, user))
                .ReturnsAsync(true);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.EditHallAsync(hallModel, expectedId);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.GetHallAsync(expectedId),
                Times.Once);

            _repository.Verify(_ => _.EditHallAsync(hall, user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task RemoveHall()
        {
            var expectedId = 3;

            var hall = new Halls
            {
                Id = expectedId,
                Name = "Олимп",
                Type = "Crossfit (not Aff.),Fitness,Gym,Yoga",
                Description = "Самая крупная сеть клубов в Западной Украине. 5 специализированных залов со всем необходимым оборудованием в городе Льва. Площадь залов составляет от 400 до 2500кв.м. Залы условно поделены на зоны от кардио до тяжёлой атлетики и кроссфит зон. Качественная система вентиляции и кондиционирования делает занятия ещё эффективней. Общая сауна для отдыха.Квалифицированные тренера, которые помогут даже в скретчинге и диетологии. Олимп рекомендует Василий Вирастюк.",
                Town = "Львов",
                Rating = "10.0",
                EmblemHallId = 3
            };

            _repository.Setup(_ => _.GetHallAsync(expectedId))
                .ReturnsAsync(hall);

            _repository.Setup(_ => _.RemoveHallAsync(hall))
                .ReturnsAsync(true);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.RemoveHallAsync(expectedId);

            _repository.Verify(_ => _.GetHallAsync(expectedId),
                Times.Once);

            _repository.Verify(_ => _.RemoveHallAsync(hall),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task JoinHall()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var hallId = 3;

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.JoinHallAsync(user))
                .ReturnsAsync(true);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.JoinHallAsync(hallId, user);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.JoinHallAsync(user),
                Times.Once);

            Assert.True(result);
        }

        [Fact]
        public async Task ExitHall()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var hallId = 3;

            _userRepository.Setup(_ => _.GetUserAsync(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.ExitHallAsync(user))
                .ReturnsAsync(true);

            IHallsService service = new HallsService(_repository.Object, _userRepository.Object);

            var result = await service.ExitHallAsync(hallId, user);

            _userRepository.Verify(_ => _.GetUserAsync(user.Id),
                Times.Once);

            _repository.Verify(_ => _.ExitHallAsync(user),
                Times.Once);

            Assert.True(result);
        }
    }
}
