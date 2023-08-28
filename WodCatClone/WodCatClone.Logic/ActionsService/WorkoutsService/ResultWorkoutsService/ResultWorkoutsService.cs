using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.ResultWorkoutsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService
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
            var user = AuthService.AuthService.User;

            if (user is null)
            {
                return false;
            }

            resultWorkouts.UserId = user.Id;
            resultWorkouts.PublishDate = DateTime.Now;

            user.Points += 10;

            return await _repository.AddResultWorkouts(resultWorkouts, user);
        }

        public async Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var user = AuthService.AuthService.User;

            if (user is null)
            {
                return false;
            }

            var resultWorkoutEdit = _repository.GetResultWorkout(id);

            if (resultWorkoutEdit is null)
            {
                return false;
            }

            return _repository.EditResultWorkouts(resultWorkouts, resultWorkoutEdit, user);
        }

        public bool DeleteResultWorkouts(int id)
        {
            var resultWorkoutRemove = _repository.GetResultWorkout(id);

            if (resultWorkoutRemove is null)
            {
                return false;
            }

            return _repository.DeleteResultWorkouts(resultWorkoutRemove);
        }
    }
}
