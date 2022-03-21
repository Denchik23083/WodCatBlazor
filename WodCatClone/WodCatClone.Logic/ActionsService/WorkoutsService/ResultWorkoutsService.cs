using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public class ResultWorkoutsService : IResultWorkoutsService
    {
        private readonly IResultWorkoutsRepository _repository;
        public static int ResultWorkoutsId;

        public ResultWorkoutsService(IResultWorkoutsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id)
        {
            return _repository.GetAllResultWorkouts(id);
        }

        public int GetCountResultWorkouts(int id)
        {
            return _repository.GetCountResultWorkouts(id);
        }

        public bool AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            return _repository.AddResultWorkouts(resultWorkouts);
        }

        public bool DeleteResultWorkouts()
        {
            return _repository.DeleteResultWorkouts(ResultWorkoutsId);
        }

        public void PostId(int itemId)
        {
            ResultWorkoutsId = itemId;
        }
    }
}
