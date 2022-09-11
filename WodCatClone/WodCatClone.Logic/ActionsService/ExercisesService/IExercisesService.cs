using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ExercisesService
{
    public interface IExercisesService
    {
        IEnumerable<Exercises> GetAllExercises();

        Exercises GetExercise(int exerciseId);
    }
}
