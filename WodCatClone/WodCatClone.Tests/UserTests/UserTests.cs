using Moq;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Tests.UserTests
{
    public class UserTests
    {
        private readonly Mock<IUserRepository> _repository;

        public UserTests()
        {
            _repository = new Mock<IUserRepository>();
        }
    }
}
