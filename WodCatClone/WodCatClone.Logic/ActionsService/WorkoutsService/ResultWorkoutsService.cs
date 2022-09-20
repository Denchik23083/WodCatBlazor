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

            resultWorkouts.UserId = AuthService.AuthService.User.Id;

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

            return _repository.EditResultWorkouts(resultWorkouts, id, user);
        }

        public bool DeleteResultWorkouts(int id)
        {
            return _repository.DeleteResultWorkouts(id);
        }
    }
}
