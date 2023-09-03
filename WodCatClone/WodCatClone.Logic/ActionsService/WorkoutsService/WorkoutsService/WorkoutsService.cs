using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService
{
    public class WorkoutsService : IWorkoutsService
    {
        private readonly IWorkoutsRepository _repository;

        public WorkoutsService(IWorkoutsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Workouts>> GetAllWorkouts()
        {
            return await _repository.GetAllWorkouts();
        }

        public async Task<Workouts?> GetWorkout(int workoutId)
        {
            return await _repository.GetWorkout(workoutId);
        }
    }
}
