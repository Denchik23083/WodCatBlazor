using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        Task<IEnumerable<WorkoutsExercises>> GetAllWorkoutsExercises(int id);

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id);

        Task<Workouts> GetWorkout(int workoutId);

        Workouts GetWorkout(int? workoutId);
    }
}
