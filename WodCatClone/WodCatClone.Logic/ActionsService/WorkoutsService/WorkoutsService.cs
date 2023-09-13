using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
{
    public class WorkoutsService : IWorkoutsService
    {
        private readonly IWorkoutsRepository _repository;
        private readonly IUserRepository _userRepository;

        public WorkoutsService(IWorkoutsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Workouts>> GetAllWorkoutsAsync()
        {
            return await _repository.GetAllWorkoutsAsync();
        }

        public async Task<Workouts?> GetWorkoutAsync(int workoutId)
        {
            return await _repository.GetWorkoutAsync(workoutId);
        }

        public async Task<bool> AddResultWorkoutsAsync(ResultWorkouts resultWorkouts)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            resultWorkouts.UserId = loginUser.Id;
            resultWorkouts.PublishDate = DateTime.Now;

            loginUser.Points += 10;

            return await _repository.AddResultWorkoutsAsync(resultWorkouts, loginUser);
        }

        public async Task<bool> EditResultWorkoutsAsync(ResultWorkouts resultWorkouts, int id)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var resultWorkoutEdit = await _repository.GetResultWorkoutAsync(id);

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

            return await _repository.EditResultWorkoutsAsync(resultWorkoutEdit, loginUser);
        }

        public async Task<bool> RemoveResultWorkoutsAsync(int id)
        {
            var resultWorkoutRemove = await _repository.GetResultWorkoutAsync(id);

            if (resultWorkoutRemove is null)
            {
                return false;
            }

            return await _repository.RemoveResultWorkoutsAsync(resultWorkoutRemove);
        }
    }
}
