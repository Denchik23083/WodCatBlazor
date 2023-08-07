using WodCatClone.Db;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.WebDb.CallBackRepository
{
    public class CallBackRepository : ICallBackRepository
    {
        private readonly WodCatCloneContext _context;

        public CallBackRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _context.Question;
        }

        public Answer GetAnswer(int id)
        {
            return _context.Answer.FirstOrDefault(b => b.Id == id);
        }
    }
}
