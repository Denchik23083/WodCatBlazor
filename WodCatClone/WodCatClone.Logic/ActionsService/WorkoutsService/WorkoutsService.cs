using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;

namespace WodCatClone.Logic.ActionsService.WorkoutsService
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

        public async Task<IEnumerable<WorkoutsExercises>> GetAllWorkoutsExercises(int id)
        {
            return await _repository.GetAllWorkoutsExercises(id);
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id)
        {
            return _repository.GetAllWorkoutsExercises(id);
        }

        public async Task<Workouts> GetWorkout(int workoutId)
        {
            return await _repository.GetWorkout(workoutId);
        }

        public Workouts GetWorkout(int? workoutId)
        {
            return _repository.GetWorkout(workoutId);
        }
    }
}
