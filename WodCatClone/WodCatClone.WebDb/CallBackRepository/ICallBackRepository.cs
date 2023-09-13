using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.WebDb.CallBackRepository
{
    public interface ICallBackRepository
    {
        Task<IEnumerable<Question>> GetAllQuestionsAsync();

        Task<Answer?> GetAnswerAsync(int id);
    }
}
