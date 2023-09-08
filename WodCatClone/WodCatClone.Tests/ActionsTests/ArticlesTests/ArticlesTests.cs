using Moq;
using WodCatClone.WebDb.ActionsRepository.ArticlesRepository;

namespace WodCatClone.Tests.ActionsTests.ArticlesTests
{
    public class ArticlesTests
    {
        private readonly Mock<IArticlesRepository> _repository;

        public ArticlesTests()
        {
            _repository = new Mock<IArticlesRepository>();
        }
    }
}
