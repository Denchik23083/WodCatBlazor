using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.WebDb.CallBackRepository
{
    public interface ICallBackRepository
    {
        IEnumerable<Question> GetAllQuestions();

        Answer GetAnswer(int id);
    }
}
