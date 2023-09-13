using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ExercisesRepository
{
    public interface IExercisesRepository
    {
        Task<IEnumerable<Exercises>> GetAllExercisesAsync();

        Task<Exercises?> GetExerciseAsync(int exerciseId);
    }
}
