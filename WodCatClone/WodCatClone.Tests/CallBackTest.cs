﻿using System.Linq;
using WodCatClone.Db;
using Xunit;

namespace WodCatClone.Tests
{
    public class CallBackTest
    {
        [Fact]
        public void GetAllQuestionsTest()
        {
            var context = new TestsWodCatCloneDbContext();
            
            var countQuestions = 6;
            var questions = context.Question;
            
            Assert.NotNull(questions);
            Assert.Equal(countQuestions, questions.Count());
        }

        [Fact]
        public void GetAnswerTest()
        {
            var context = new TestsWodCatCloneDbContext();

            var id = 1;
            var answer = context.Answer.FirstOrDefault(b => b.Id == id);

            Assert.NotNull(answer);
            Assert.Equal(id, answer.Id);
        }
    }
}