using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.WebDb.CallBackRepository
{
    public interface ICallBackRepository
    {
        Task<IEnumerable<Question>> GetAllQuestions();

        Task<Answer?> GetAnswer(int id);
    }
}
