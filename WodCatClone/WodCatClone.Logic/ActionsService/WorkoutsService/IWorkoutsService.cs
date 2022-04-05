using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IWorkoutsService
    {
        IEnumerable<Workouts> GetAllWorkouts();

        Workouts GetWorkout(int workoutId);

        string GetImage(int imageId);
    }
}
