using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        Task<IEnumerable<Workouts>> GetAllWorkouts();

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id);

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id);

        Workouts GetWorkout(int workoutId);

        Workouts GetWorkout(int? workoutId);
    }
}
