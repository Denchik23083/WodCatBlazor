using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public interface IProgramsService
    {
        IEnumerable<Programs> GetAllPrograms();

        IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id);

        IEnumerable<User> GetAllProgramsUsers(int id);

        Programs GetProgram(int id);

        string GetImage(int? programsEmblemId);

        bool BeginProgram(int id, User user);

        bool StopProgram(int id, User user);

        int Subscribers(int programId);
    }
}
