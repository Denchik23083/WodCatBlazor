using Moq;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;
using WodCatClone.WebDb.CallBackRepository;
using Xunit;

namespace WodCatClone.Tests.CallBackTests
{
    public class CallBackTests
    {
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
        

            var mock = new Mock<ICallBackRepository>();
            mock.Setup(_ => _.GetAllQuestions())
                .ReturnsAsync(() => questions);

            ICallBackService service = new CallBackService(mock.Object);

            var result = await service.GetAllQuestions();

            Assert.NotNull(result);
            Assert.Equal(questions.Count, result.Count());
        }

        [Fact]
        public async Task GetAnswer()
        {
            var answer = new Answer { Id = 5, Name = "Только те, которые создал" };

            var mock = new Mock<ICallBackRepository>();
            mock.Setup(_ => _.GetAnswer(answer.Id))
                .ReturnsAsync(() => answer);

            ICallBackService service = new CallBackService(mock.Object);

            var result = await service.GetAnswer(answer.Id);

            Assert.NotNull(result);
            Assert.Equal(answer.Id, result!.Id);
        }
    }
}
