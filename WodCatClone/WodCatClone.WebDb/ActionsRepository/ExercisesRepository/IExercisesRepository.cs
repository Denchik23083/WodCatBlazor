using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ExercisesRepository
{
    public interface IExercisesRepository
    {
        Task<IEnumerable<Exercises>> GetAllExercises();

        Task<Exercises> GetExercise(int exerciseId);
    }
}
