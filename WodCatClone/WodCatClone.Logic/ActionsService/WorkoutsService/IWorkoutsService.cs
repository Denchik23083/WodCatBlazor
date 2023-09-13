using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        Task<IEnumerable<Workouts>> GetAllWorkoutsAsync();

        Task<Workouts?> GetWorkoutAsync(int workoutId);

        Task<bool> AddResultWorkoutsAsync(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkoutsAsync(ResultWorkouts resultWorkouts, int id);

        Task<bool> RemoveResultWorkoutsAsync(int id);
    }
}
