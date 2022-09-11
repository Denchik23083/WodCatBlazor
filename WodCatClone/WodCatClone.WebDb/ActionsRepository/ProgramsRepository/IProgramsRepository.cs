using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        Task<IEnumerable<Programs>> GetAllPrograms();

        IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id);

        IEnumerable<User> GetAllProgramsUsers(int id);

        ProgramTimeUser GetProgramTimeUser(int programId, User user);

        Programs GetProgram(int id);

        Programs GetProgram(int? id);

        Task<ProgramEmblem> GetImage(int? programsEmblemId);

        bool BeginProgram(int id, User user);

        bool StopProgram(int id, User user, bool isFinish);

        Task<int> Subscribers(int programId);
    }
}
