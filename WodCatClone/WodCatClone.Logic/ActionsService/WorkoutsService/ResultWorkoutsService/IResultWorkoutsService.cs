using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService
{
    public interface IResultWorkoutsService
    {
        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        Task<bool> DeleteResultWorkouts(int id);
    }
}
