using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IResultWorkoutsRepository
    {
        IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id);

        bool AddResultWorkouts(ResultWorkouts resultWorkouts, User user);

        bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id, User user);

        bool DeleteResultWorkouts(int resultWorkoutsId);
    }
}
