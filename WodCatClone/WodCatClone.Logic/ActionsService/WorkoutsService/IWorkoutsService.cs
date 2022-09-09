using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id);

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id);

        Workouts GetWorkout(int workoutId);

        Workouts GetWorkout(int? workoutId);
    }
}
