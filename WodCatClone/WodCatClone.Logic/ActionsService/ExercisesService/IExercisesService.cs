using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.ExercisesService
{
    public interface IExercisesService
    {
        Task<IEnumerable<Exercises>> GetAllExercises();

        Task<Exercises?> GetExercise(int exerciseId);
    }
}
