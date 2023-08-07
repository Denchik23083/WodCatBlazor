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

        public IEnumerable<Question> GetAllQuestions()
        {
            return _repository.GetAllQuestions();
        }

        public Answer GetAnswer(int id)
        {
            return _repository.GetAnswer(id);
        }
    }
}
