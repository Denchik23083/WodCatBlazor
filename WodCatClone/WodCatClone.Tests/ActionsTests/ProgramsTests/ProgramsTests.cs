using Moq;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Tests.Utilities;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;
using WodCatClone.WebDb.UserRepository;
using Xunit;

namespace WodCatClone.Tests.ActionsTests.ProgramsTests
{
    public class ProgramsTests : AuthUser
    {
        private readonly Mock<IProgramsRepository> _repository;
        private readonly Mock<IUserRepository> _userRepository;

        public ProgramsTests()
        {
            _repository = new Mock<IProgramsRepository>();
            _userRepository = new Mock<IUserRepository>();
        }

        [Fact]
        public async Task GetAllPrograms()
        {
            var programs = new List<Programs>
            {
                new()
                {
                    Id = 1,
                    Name = "Программа тренировки кроссфит на массу",
                    Rating = "8.0",
                    Description = "Программа тренировок состоит из 38 комплексов с большим преобладанием коротких силовых тренировок и полным отсутствием кардио нагрузки. План тренировок подойдет, если ваша цель - увеличение силы и прирост мышечной масса в ущерб выносливости. План тренировок комбинирует в себе силовые тренировки и короткие “тяжелые” комплексы кроссфит, преобладают базовые упражнения с большими весами на малое кол-во повторов, что является основным условием развития силы и набора массы (мышечной массы) В данной программе встречаются технически сложные тяжелоатлетические упражнения, поэтому обязательно пр...",
                    Type = "Кроссфит",
                    Aim = "Набор мышечной массы",
                    HallId = 1,
                    ProgramsEmblemId = 3
                },
                new()
                {
                    Id = 2,
                    Name = "Plan for the amateur",
                    Description = "План, для аматоров CrossFit План для тренировок в зале с использованием упражнений на силу и выносливость, состоящая в основном из аэробных упражнений, гимнастики (упражнения с весом собственного тела) и тяжёлой атлетики, для людей которые имеют слабую или среднюю базовую подготовку, с целью поддержания и увеличиния физической формы. Если твой уровень выше чем этот то тебе на этот план------> CoachMarchenko",
                    Type = "Тяжелая атлетика",
                    Aim = "На силу",
                    ProgramsEmblemId = 5
                },
                new()
                {
                    Id = 3,
                    Name = "Кроссфит программа тренировок дома без оборудования",
                    Description = "Программа тренировок идеально подойдет для новичков. Большая часть плана состоит из гимнастических тренировок со своим весом и не требует вспомогательных предметов для выполнения. Сами же упражнения очень просты и наверняка давно вам знакомы, поэтому вы можете не обладать специальными знаниями, чтобы заниматься по данному плану. С этой программой вам не нужно обязательно быть в зале во время тренировки, вы можете выполнять тренировки в любом удобном месте.",
                    Type = "Кроссфит",
                    Aim = "Fitness",
                    HallId = 2,
                    ProgramsEmblemId = 1
                },
                new()
                {
                    Id = 4,
                    Name = "Вводной план тренировок для новичков в Кроссфите",
                    Description = "План тренировки рассчитан на людей решивших начать тренировки по системе Кроссфит. Тренировочный план сбалансированный, используются только базовые и упрощенные упражнения. Но если Вы не имеете опыта выполнения данных упражнений, обязательно выполнение данного плана под руководством сертифицированного тренера",
                    Type = "Кроссфит",
                    Aim = "Fitness",
                    HallId = 3,
                    Rating = "10.0",
                    ProgramsEmblemId = 2
                },
                new()
                {
                    Id = 5,
                    Name = "NRC 21.1 Prep",
                    Type = "Фитнесс",
                    Aim = "Performance",
                    ProgramsEmblemId = 4
                }
            };

            _repository.Setup(_ => _.GetAllPrograms())
                .ReturnsAsync(programs);

            IProgramsService service = new ProgramsService(_repository.Object, _userRepository.Object);

            var result = await service.GetAllPrograms();

            _repository.Verify(_ => _.GetAllPrograms(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(programs.Count, result.Count());
        }

        [Fact]
        public async Task GetProgram()
        {
            var expectedId = 4;

            var program = new Programs
            {
                Id = expectedId,
                Name = "Вводной план тренировок для новичков в Кроссфите",
                Description = "План тренировки рассчитан на людей решивших начать тренировки по системе Кроссфит. Тренировочный план сбалансированный, используются только базовые и упрощенные упражнения. Но если Вы не имеете опыта выполнения данных упражнений, обязательно выполнение данного плана под руководством сертифицированного тренера",
                Type = "Кроссфит",
                Aim = "Fitness",
                HallId = 3,
                Rating = "10.0",
                ProgramsEmblemId = 2
            };

            _repository.Setup(_ => _.GetProgram(expectedId))
                .ReturnsAsync(program);

            IProgramsService service = new ProgramsService(_repository.Object, _userRepository.Object);

            var result = await service.GetProgram(expectedId);

            _repository.Verify(_ => _.GetProgram(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }

        [Fact]
        public async Task BeginProgram()
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var programId = 4;

            var newProgramTimeUser = new ProgramTimeUser
            {
                BeginProgramDate = DateTime.Now,
                ProgramsId = programId,
                UserId = user.Id
            };

            var programTimeUser = user.ProgramTimeUsers?.FirstOrDefault(_ => _.ProgramsId == programId);

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.BeginProgram(user, It.IsAny<ProgramTimeUser>(), It.IsAny<ProgramTimeUser>()))
                .ReturnsAsync(true);

            IProgramsService service = new ProgramsService(_repository.Object, _userRepository.Object);

            var result = await service.BeginProgram(programId, user);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.BeginProgram(user, It.IsAny<ProgramTimeUser>(), It.IsAny<ProgramTimeUser>()),
                Times.Once);

            Assert.True(result);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task StopProgram(bool isFinish)
        {
            var authResult = await IsAuthUser();

            Assert.True(authResult);

            var user = User();

            var programId = 4;

            var programTimeUser = user.ProgramTimeUsers?.FirstOrDefault(_ => _.ProgramsId == programId);

            _userRepository.Setup(_ => _.GetUser(user.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.StopProgram(user, programTimeUser, isFinish))
                .ReturnsAsync(true);

            IProgramsService service = new ProgramsService(_repository.Object, _userRepository.Object);

            var result = await service.StopProgram(programId, user, isFinish);

            _userRepository.Verify(_ => _.GetUser(user.Id),
                Times.Once);

            _repository.Verify(_ => _.StopProgram(user, programTimeUser, isFinish),
                Times.Once);

            Assert.True(result);
        }
    }
}
