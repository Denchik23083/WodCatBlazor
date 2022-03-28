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

        public bool EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var resultWorkoutEdit = _context.ResultWorkouts.FirstOrDefault(b => b.Id == id);

            if (resultWorkoutEdit is null)
            {
                return false;
            }
            
            resultWorkoutEdit.Comment = resultWorkouts.Comment;
            resultWorkoutEdit.Fascination = resultWorkouts.Fascination;
            resultWorkoutEdit.Load = resultWorkouts.Load;
            resultWorkoutEdit.Minutes = resultWorkouts.Minutes;
            resultWorkoutEdit.Seconds = resultWorkouts.Seconds;
            resultWorkoutEdit.Repeat = resultWorkouts.Repeat;
            resultWorkoutEdit.PublishDate = resultWorkouts.PublishDate;

            _context.SaveChanges();

            return true;
        }

        public bool DeleteResultWorkouts(int resultWorkoutsId)
        {
            var resultWorkoutRemove = _context.ResultWorkouts.FirstOrDefault(b => b.Id == resultWorkoutsId);

            if (resultWorkoutRemove is null)
            {
                return false;
            }

            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            _context.SaveChanges();

            return true;
        }
    }
}
