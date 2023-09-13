using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public class WorkoutsRepository : IWorkoutsRepository
    {
        private readonly WodCatCloneContext _context;

        public WorkoutsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Workouts>> GetAllWorkoutsAsync()
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .Include(_ => _.ResultWorkouts)
                .ToListAsync();
        }

        public async Task<Workouts?> GetWorkoutAsync(int workoutId)
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.ResultWorkouts)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .FirstOrDefaultAsync(_ => _.Id == workoutId);
        }

        public async Task<ResultWorkouts?> GetResultWorkoutAsync(int id)
        {
            return await _context.ResultWorkouts.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> AddResultWorkoutsAsync(ResultWorkouts resultWorkouts, User loginUser)
        {
            await _context.ResultWorkouts.AddAsync(resultWorkouts);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditResultWorkoutsAsync(ResultWorkouts resultWorkoutEdit, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveResultWorkoutsAsync(ResultWorkouts resultWorkoutRemove)
        {
            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
