using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.ResultWorkoutsRepository
{
    public interface IResultWorkoutsRepository
    {
        Task<ResultWorkouts?> GetResultWorkout(int id);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts, User loginUser);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkoutEdit, User loginUser);

        Task<bool> DeleteResultWorkouts(ResultWorkouts resultWorkoutRemove);
    }
}
