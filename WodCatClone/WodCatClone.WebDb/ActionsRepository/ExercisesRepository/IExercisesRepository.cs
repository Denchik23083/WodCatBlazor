using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ExercisesRepository
{
    public interface IExercisesRepository
    {
        IEnumerable<Exercises> GetAllExercises();

        Exercises GetExercise(int exerciseId);
    }
}
