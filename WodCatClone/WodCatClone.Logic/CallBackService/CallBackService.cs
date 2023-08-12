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

        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            return await _repository.GetAllQuestions();
        }

        public async Task<Answer?> GetAnswer(int id)
        {
            return await _repository.GetAnswer(id);
        }
    }
}
