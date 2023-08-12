using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ExercisesRepository
{
    public class ExercisesRepository : IExercisesRepository
    {
        private readonly WodCatCloneContext _context;

        public ExercisesRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Exercises>> GetAllExercises()
        {
            return await _context.Exercises.ToListAsync();
        }

        public async Task<Exercises?> GetExercise(int exerciseId)
        {
            return await _context.Exercises.FirstOrDefaultAsync(x => x.Id == exerciseId);
        }
    }
}
