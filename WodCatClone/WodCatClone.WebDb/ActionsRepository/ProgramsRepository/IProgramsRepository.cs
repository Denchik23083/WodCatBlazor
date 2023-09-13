using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        Task<IEnumerable<Programs>> GetAllProgramsAsync();

        Task<Programs?> GetProgramAsync(int id);

        Task<bool> BeginProgramAsync(User loginUser, ProgramTimeUser? programTimeUser, ProgramTimeUser newProgramTimeUser);

        Task<bool> StopProgramAsync(User loginUser, ProgramTimeUser? programTimeUser, bool isFinish);
    }
}
