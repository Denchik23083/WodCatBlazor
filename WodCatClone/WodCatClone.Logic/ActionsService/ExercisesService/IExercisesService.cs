using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ExercisesService
{
    public interface IExercisesService
    {
        Task<IEnumerable<Exercises>> GetAllExercisesAsync();

        Task<Exercises?> GetExerciseAsync(int exerciseId);
    }
}
