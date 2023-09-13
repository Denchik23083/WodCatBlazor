using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public interface IProgramsService
    {
        Task<IEnumerable<Programs>> GetAllProgramsAsync();

        Task<Programs?> GetProgramAsync(int id);

        Task<bool> BeginProgramAsync(int id, User user);

        Task<bool> StopProgramAsync(int id, User user, bool isFinish);
    }
}
