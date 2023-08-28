using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id);

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id);

        Task<Workouts?> GetWorkout(int workoutId);

        Workouts GetWorkout(int? workoutId);
    }
}
