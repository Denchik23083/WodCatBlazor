using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        Task<Workouts?> GetWorkout(int workoutId);
    }
}
