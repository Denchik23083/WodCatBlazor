using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        IEnumerable<Workouts> GetAllWorkouts();

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id);

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id);

        Workouts GetWorkout(int workoutId);

        Workouts GetWorkout(int? workoutId);
    }
}
