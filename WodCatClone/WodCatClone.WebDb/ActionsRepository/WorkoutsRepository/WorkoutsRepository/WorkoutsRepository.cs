using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository.WorkoutsRepository
{
    public class WorkoutsRepository : IWorkoutsRepository
    {
        private readonly WodCatCloneContext _context;

        public WorkoutsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Workouts> GetAllWorkouts()
        {
            return _context.Workouts;
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int id)
        {
            return _context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
        }

        public IEnumerable<WorkoutsExercises> GetAllWorkoutsExercises(int? id)
        {
            return _context.WorkoutsExercises.Where(b => b.WorkoutsId == id);
        }

        public Workouts GetWorkout(int workoutId)
        {
            return _context.Workouts.FirstOrDefault(x => x.Id == workoutId);
        }

        public Workouts GetWorkout(int? workoutId)
        {
            return _context.Workouts.FirstOrDefault(x => x.Id == workoutId);
        }
    }
}
