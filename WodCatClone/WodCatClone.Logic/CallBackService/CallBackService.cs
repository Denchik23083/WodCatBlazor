using WodCatClone.Db.Entities.CallBack;
using WodCatClone.WebDb.CallBackRepository;

namespace WodCatClone.Logic.CallBackService
{
    public class CallBackService : ICallBackService
    {
        private readonly ICallBackRepository _repository;

        public CallBackService(ICallBackRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Question>> GetAllQuestionsAsync()
        {
            return await _repository.GetAllQuestionsAsync();
        }

        public async Task<Answer?> GetAnswerAsync(int id)
        {
            return await _repository.GetAnswerAsync(id);
        }
    }
}
