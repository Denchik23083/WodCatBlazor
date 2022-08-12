using System.Linq;
using WodCatClone.Db;
using Xunit;

namespace WodCatClone.Tests
{
    public class CallBackTest
    {
        [Fact]
        public void Get_All_Questions()
        {
            var context = new TestsWodCatCloneContext();
            
            var expectedQuestions = 6;
            var questions = context.Question;
            
            Assert.NotNull(questions);
            Assert.Equal(expectedQuestions, questions.Count());
        }

        [Fact]
        public void Get_Answer()
        {
            var context = new TestsWodCatCloneContext();

            var id = 1;
            var answer = context.Answer.FirstOrDefault(b => b.Id == id);

            Assert.NotNull(answer);
            Assert.Equal(id, answer.Id);
        }
    }
}
