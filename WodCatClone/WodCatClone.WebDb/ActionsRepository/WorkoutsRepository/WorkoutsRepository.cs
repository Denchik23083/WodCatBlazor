using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

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
            return await _context.Workouts.ToListAsync();
        }

        public async Task<IEnumerable<WorkoutsExercises>> GetAllWorkoutsExercises(int id)
        {
            return await _context.WorkoutsExercises
                .Where(b => b.WorkoutsId == id)
                .ToListAsync();
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id)
        {
            return _context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
        }

        public async Task<Workouts> GetWorkout(int workoutId)
        {
            return await _context.Workouts.FirstOrDefaultAsync(x => x.Id == workoutId);
        }

        public Workouts GetWorkout(int? workoutId)
        {
            return _context.Workouts.FirstOrDefault(x => x.Id == workoutId);
        }
    }
}
