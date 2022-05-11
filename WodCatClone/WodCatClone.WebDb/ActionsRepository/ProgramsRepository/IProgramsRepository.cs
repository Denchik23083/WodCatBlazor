using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public interface IProgramsRepository
    {
        IEnumerable<Programs> GetAllPrograms();

        IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id);

        IEnumerable<User> GetAllProgramsUsers(int id);

        Programs GetProgram(int id);

        bool BeginProgram(int id, User user);

        bool StopProgram(int id, User user);
    }
}
