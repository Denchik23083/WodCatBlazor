using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IResultWorkoutsService
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        int GetCountResultWorkouts(int id);

        bool AddResultWorkouts(ResultWorkouts resultWorkouts);

        bool DeleteResultWorkouts();

        void PostId(int itemId);
    }
}
