using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        Task<IEnumerable<Programs>> GetAllPrograms();

        Task<ProgramTimeUser?> GetProgramTimeUser(int programId, User user);

        Task<Programs?> GetProgram(int id);

        Task<bool> BeginProgram(int id, User loginUser, ProgramTimeUser? programTimeUser, ProgramTimeUser newProgramTimeUser);

        Task<bool> StopProgram(int id, User loginUser, ProgramTimeUser? programTimeUser, bool isFinish);
    }
}
