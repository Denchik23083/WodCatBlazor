using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        Task<IEnumerable<Workouts>> GetAllWorkoutsAsync();

        Task<Workouts?> GetWorkoutAsync(int workoutId);

        Task<ResultWorkouts?> GetResultWorkoutAsync(int id);

        Task<bool> AddResultWorkoutsAsync(ResultWorkouts resultWorkouts, User loginUser);

        Task<bool> EditResultWorkoutsAsync(ResultWorkouts resultWorkoutEdit, User loginUser);

        Task<bool> RemoveResultWorkoutsAsync(ResultWorkouts resultWorkoutRemove);
    }
}
