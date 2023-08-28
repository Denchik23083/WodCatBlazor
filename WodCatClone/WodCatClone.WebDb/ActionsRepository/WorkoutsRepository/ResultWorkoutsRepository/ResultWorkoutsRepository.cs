using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.ResultWorkoutsRepository
{
    public class ResultWorkoutsRepository : IResultWorkoutsRepository
    {
        private readonly WodCatCloneContext _context;

        public ResultWorkoutsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<ResultWorkouts?> GetResultWorkout(int id)
        {
            return await _context.ResultWorkouts.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts, User loginUser)
        {
            await _context.ResultWorkouts.AddAsync(resultWorkouts);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditResultWorkouts(ResultWorkouts resultWorkoutEdit, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteResultWorkouts(ResultWorkouts resultWorkoutRemove)
        {
            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
