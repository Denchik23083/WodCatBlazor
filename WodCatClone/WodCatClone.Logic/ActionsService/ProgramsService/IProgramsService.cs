using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ProgramsService
{
    public interface IProgramsService
    {
        IEnumerable<Programs> GetAllPrograms();

        IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id);

        Programs GetProgram(int id);
    }
}
