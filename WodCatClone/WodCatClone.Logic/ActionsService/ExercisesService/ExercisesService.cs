using WodCatClone.Db.Entities.Actions;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;

namespace WodCatClone.Logic.ActionsService.ExercisesService
{
    public class ExercisesService : IExercisesService
    {
        private readonly IExercisesRepository _repository;

        public ExercisesService(IExercisesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Exercises>> GetAllExercisesAsync()
        {
            return await _repository.GetAllExercisesAsync();
        }

        public async Task<Exercises?> GetExerciseAsync(int exerciseId)
        {
            return await _repository.GetExerciseAsync(exerciseId);
        }
    }
}
