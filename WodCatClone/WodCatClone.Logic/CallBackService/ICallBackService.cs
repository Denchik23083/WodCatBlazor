using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Logic.CallBackService
{
    public interface ICallBackService
    {
        Task<IEnumerable<Question>> GetAllQuestionsAsync();

        Task<Answer?> GetAnswerAsync(int id);
    }
}
