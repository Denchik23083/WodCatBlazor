using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.ResultWorkoutsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService
{
    public class ResultWorkoutsService : IResultWorkoutsService
    {
        private readonly IResultWorkoutsRepository _repository;
        private readonly IUserRepository _userRepository;

        public ResultWorkoutsService(IResultWorkoutsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id)
        {
            return _repository.GetAllResultWorkouts(id);
        }

        public bool AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            return _repository.AddResultWorkouts(resultWorkouts, user);
        }

        public bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

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
