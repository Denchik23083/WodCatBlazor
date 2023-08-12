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

        public async Task<IEnumerable<Exercises>> GetAllExercises()
        {
            return await _repository.GetAllExercises();
        }

        public async Task<Exercises?> GetExercise(int exerciseId)
        {
            return await _repository.GetExercise(exerciseId);
        }
    }
}
