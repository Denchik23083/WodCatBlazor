using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

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

        public ResultWorkouts GetResultWorkout(int id)
        {
            return _context.ResultWorkouts.FirstOrDefault(b => b.Id == id);
        }

        public bool AddResultWorkouts(ResultWorkouts resultWorkouts, User user)
        {
            resultWorkouts.UserId = user.Id;

            _context.ResultWorkouts.Add(resultWorkouts);

            user.Points += 10;

            _context.SaveChanges();

            return true;
        }

        public bool EditResultWorkouts(ResultWorkouts resultWorkouts, ResultWorkouts resultWorkoutEdit, User user)
        {
            resultWorkoutEdit.Comment = resultWorkouts.Comment;
            resultWorkoutEdit.Fascination = resultWorkouts.Fascination;
            resultWorkoutEdit.Load = resultWorkouts.Load;
            resultWorkoutEdit.Time = resultWorkouts.Time;
            resultWorkoutEdit.Repeat = resultWorkouts.Repeat;
            resultWorkoutEdit.PublishDate = resultWorkouts.PublishDate;

            user.Points += 5;

            _context.SaveChanges();

            return true;
        }

        public bool DeleteResultWorkouts(ResultWorkouts resultWorkoutRemove)
        {
            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            _context.SaveChanges();

            return true;
        }
    }
}
