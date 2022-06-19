using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IResultWorkoutsRepository
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        bool AddResultWorkouts(ResultWorkouts resultWorkouts);

        bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        bool DeleteResultWorkouts(int resultWorkoutsId);
    }
}
