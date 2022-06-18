using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IWorkoutsRepository
    {
        IEnumerable<Workouts> GetAllWorkouts();

        IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id);

        Workouts GetWorkout(int workoutId);

        HallEmblem GetImage(int? imageId);
    }
}
