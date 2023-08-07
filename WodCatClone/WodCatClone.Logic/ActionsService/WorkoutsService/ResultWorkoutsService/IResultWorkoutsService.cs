using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService
{
    public interface IResultWorkoutsService
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        bool DeleteResultWorkouts(int id);
    }
}
