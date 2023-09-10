using Moq;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;
using WodCatClone.WebDb.CallBackRepository;
using Xunit;

namespace WodCatClone.Tests.CallBackTests
{
    public class CallBackTests
    {
        private readonly Mock<ICallBackRepository> _repository;

        public CallBackTests()
        {
            _repository = new Mock<ICallBackRepository>();
        }

        [Fact]
        public async Task GetAllQuestions()
        {
            var questions = new List<Question>
            {
                new() { Id = 1, Name = "Как добавить результат о тренировке?", AnswerId = 1 },
                new() { Id = 2, Name = "Как получить баллы?", AnswerId = 3 },
                new() { Id = 3, Name = "Как присоединиться к залу?", AnswerId = 2 },
                new() { Id = 4, Name = "Как поднятся в рейтинге игроков?", AnswerId = 4 },
                new() { Id = 5, Name = "Какие залы можно редактировать и удалять?", AnswerId = 5 },
                new() { Id = 6, Name = "Как начать тренировку?", AnswerId = 6 },
                new() { Id = 7, Name = "Можно ли редактировать или удалить результат тренировки?", AnswerId = 7 },
                new() { Id = 8, Name = "Зачем нужна программа тренировок?", AnswerId = 8 },
                new() { Id = 9, Name = "Можно ли редактировать или удалить программу тренировок, тренировку или упражнения?", AnswerId = 9 },
                new() { Id = 10, Name = "Как получить баллы за мероприятие?", AnswerId = 10 }
            };

            _repository.Setup(_ => _.GetAllQuestions())
                .ReturnsAsync(questions);

            ICallBackService service = new CallBackService(_repository.Object);

            var result = await service.GetAllQuestions();

            _repository.Verify(_ => _.GetAllQuestions(), 
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(questions.Count, result.Count());
        }

        [Fact]
        public async Task GetAnswer()
        {
            var expectedId = 5;

            var answer = new Answer { Id = expectedId, Name = "Только те, которые создал" };
            
            _repository.Setup(_ => _.GetAnswer(expectedId))
                .ReturnsAsync(answer);

            ICallBackService service = new CallBackService(_repository.Object);

            var result = await service.GetAnswer(expectedId);

            _repository.Verify(_ => _.GetAnswer(expectedId), 
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(expectedId, result!.Id);
        }
    }
}
