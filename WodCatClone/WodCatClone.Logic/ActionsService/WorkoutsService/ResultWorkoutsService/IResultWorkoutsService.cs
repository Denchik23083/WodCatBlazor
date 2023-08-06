using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService
{
    public interface IResultWorkoutsService
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        bool AddResultWorkouts(ResultWorkouts resultWorkouts);

        bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        bool DeleteResultWorkouts(int id);
    }
}
