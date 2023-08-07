using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Logic.CallBackService
{
    public interface ICallBackService
    {
        IEnumerable<Question> GetAllQuestions();

        Answer GetAnswer(int id);
    }
}
