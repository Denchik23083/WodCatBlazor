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

        public IEnumerable<Exercises> GetAllExercises()
        {
            return _repository.GetAllExercises();
        }

        public Exercises GetExercise(int exerciseId)
        {
            return _repository.GetExercise(exerciseId);
        }
    }
}
