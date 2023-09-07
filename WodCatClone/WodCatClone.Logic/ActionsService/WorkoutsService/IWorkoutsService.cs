using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        Task<Workouts?> GetWorkout(int workoutId);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        Task<bool> DeleteResultWorkouts(int id);
    }
}
