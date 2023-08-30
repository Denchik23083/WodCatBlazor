using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public interface IProgramsService
    {
        Task<IEnumerable<Programs>> GetAllPrograms();

        Task<ProgramTimeUser?> GetProgramTimeUser(int programId, User user);

        Task<Programs?> GetProgram(int id);

        Task<bool> BeginProgram(int id, User user);

        Task<bool> StopProgram(int id, User user, bool isFinish);
    }
}
