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

        public async Task<IEnumerable<Workouts>> GetAllWorkouts()
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .Include(_ => _.ResultWorkouts)
                .ToListAsync();
        }

        public async Task<Workouts?> GetWorkout(int workoutId)
        {
            return await _context.Workouts
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.ResultWorkouts)
                .Include(_ => _.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .FirstOrDefaultAsync(_ => _.Id == workoutId);
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

        public async Task<bool> RemoveResultWorkouts(ResultWorkouts resultWorkoutRemove)
        {
            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
