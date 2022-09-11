using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public class ResultWorkoutsService : IResultWorkoutsService
    {
        private readonly IResultWorkoutsRepository _repository;

        public ResultWorkoutsService(IResultWorkoutsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ResultWorkouts>> GetAllResultWorkouts(int id)
        {
            return await _repository.GetAllResultWorkouts(id);
        }

        public async Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            resultWorkouts.UserId = AuthService.AuthService.User.Id;

            return await _repository.AddResultWorkouts(resultWorkouts);
        }

        public async Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            return await _repository.EditResultWorkouts(resultWorkouts, id);
        }

        public async Task<bool> DeleteResultWorkouts(int id)
        {
            return await _repository.DeleteResultWorkouts(id);
        }
    }
}
