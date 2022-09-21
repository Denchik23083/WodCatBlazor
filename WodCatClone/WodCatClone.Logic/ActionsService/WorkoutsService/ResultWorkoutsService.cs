using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
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

            resultWorkouts.UserId = user.Id;

            var result = _repository.AddResultWorkouts(resultWorkouts);

            if (result)
            {
                user.Points += 10;
            }

            return result;
        }

        public bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var result = _repository.EditResultWorkouts(resultWorkouts, id);

            if (result)
            {
                user.Points += 5;
            }

            return result;
        }

        public bool DeleteResultWorkouts(int id)
        {
            return _repository.DeleteResultWorkouts(id);
        }
    }
}
