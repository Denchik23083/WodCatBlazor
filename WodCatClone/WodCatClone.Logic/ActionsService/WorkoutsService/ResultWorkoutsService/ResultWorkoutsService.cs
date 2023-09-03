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

        public async Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            resultWorkouts.UserId = loginUser.Id;
            resultWorkouts.PublishDate = DateTime.Now;

            loginUser.Points += 10;

            return await _repository.AddResultWorkouts(resultWorkouts, loginUser);
        }

        public async Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var resultWorkoutEdit = await _repository.GetResultWorkout(id);

            if (resultWorkoutEdit is null)
            {
                return false;
            }

            resultWorkoutEdit.Comment = resultWorkouts.Comment;
            resultWorkoutEdit.Fascination = resultWorkouts.Fascination;
            resultWorkoutEdit.Load = resultWorkouts.Load;
            resultWorkoutEdit.Time = resultWorkouts.Time;
            resultWorkoutEdit.Repeat = resultWorkouts.Repeat;

            loginUser.Points += 5;

            return await _repository.EditResultWorkouts(resultWorkoutEdit, loginUser);
        }

        public async Task<bool> DeleteResultWorkouts(int id)
        {
            var resultWorkoutRemove = await _repository.GetResultWorkout(id);

            if (resultWorkoutRemove is null)
            {
                return false;
            }

            return await _repository.DeleteResultWorkouts(resultWorkoutRemove);
        }
    }
}
