using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public interface IResultWorkoutsService
    {
        Task<IEnumerable<ResultWorkouts>> GetAllResultWorkouts(int id);

        Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts);

        Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id);

        Task<bool> DeleteResultWorkouts(int id);
    }
}
