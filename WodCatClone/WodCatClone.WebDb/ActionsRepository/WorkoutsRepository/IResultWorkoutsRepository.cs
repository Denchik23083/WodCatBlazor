using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public interface IResultWorkoutsRepository
    {
        Task<IEnumerable<ResultWorkouts>> GetAllResultWorkouts(int id);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        Task<bool> DeleteResultWorkouts(int resultWorkoutsId);
    }
}
