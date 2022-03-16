using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.WorkoutsRepository
{
    public class ResultWorkoutsRepository : IResultWorkoutsRepository
    {
        private readonly WodCatCloneContext _context;

        public ResultWorkoutsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<ResultWorkouts> GetAllResultWorkouts(int id)
        {
            return _context.ResultWorkouts.Where(b => b.WorkoutId == id);
        }

        public int GetCountResultWorkouts(int id)
        {
            return _context.ResultWorkouts.Count(b => b.WorkoutId == id);
        }

        public bool AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            _context.ResultWorkouts.Add(resultWorkouts);
            _context.SaveChanges();

            return true;
        }
    }
}
