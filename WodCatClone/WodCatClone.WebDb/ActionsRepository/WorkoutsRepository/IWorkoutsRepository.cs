using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        Task<Workouts?> GetWorkout(int workoutId);

        Task<ResultWorkouts?> GetResultWorkout(int id);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts, User loginUser);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkoutEdit, User loginUser);

        Task<bool> RemoveResultWorkouts(ResultWorkouts resultWorkoutRemove);
    }
}
