using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        IEnumerable<Programs> GetAllPrograms();

        IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id);

        IEnumerable<User> GetAllProgramsUsers(int id);

        ProgramTimeUser GetProgramTimeUser(int programId, User user);

        Programs GetProgram(int id);

        Programs GetProgram(int? id);

        ProgramEmblem GetImage(int? programsEmblemId);

        bool BeginProgram(int id, User loginUser, ProgramTimeUser programTimeUser, ProgramTimeUser newProgramTimeUser);

        bool StopProgram(int id, User loginUser, ProgramTimeUser programTimeUser, bool isFinish);

        int Subscribers(int programId);
    }
}
