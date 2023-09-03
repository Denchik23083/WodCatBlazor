using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        Task<Workouts?> GetWorkout(int workoutId);
    }
}
