using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Logic.CallBackService
{
    public interface ICallBackService
    {
        Task<IEnumerable<Question>> GetAllQuestions();

        Task<Answer?> GetAnswer(int id);
    }
}
