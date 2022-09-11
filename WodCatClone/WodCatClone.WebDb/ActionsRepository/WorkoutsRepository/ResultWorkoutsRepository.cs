using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<ResultWorkouts>> GetAllResultWorkouts(int id)
        {
            return await _context.ResultWorkouts
                .Where(b => b.WorkoutId == id)
                .ToListAsync();
        }

        public async Task<bool> AddResultWorkouts(ResultWorkouts resultWorkouts)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = await _context.Users.FirstOrDefaultAsync(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            await _context.ResultWorkouts.AddAsync(resultWorkouts);

            user.Points += 10;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditResultWorkouts(ResultWorkouts resultWorkouts, int id)
        {
            var resultWorkoutEdit = await _context.ResultWorkouts.FirstOrDefaultAsync(b => b.Id == id);

            var loginUser = UserRepository.UserRepository.User;
            var user = await _context.Users.FirstOrDefaultAsync(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            if (resultWorkoutEdit is null)
            {
                return false;
            }
            
            resultWorkoutEdit.Comment = resultWorkouts.Comment;
            resultWorkoutEdit.Fascination = resultWorkouts.Fascination;
            resultWorkoutEdit.Load = resultWorkouts.Load;
            resultWorkoutEdit.Time = resultWorkouts.Time;
            resultWorkoutEdit.Repeat = resultWorkouts.Repeat;
            resultWorkoutEdit.PublishDate = resultWorkouts.PublishDate;

            user.Points += 5;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteResultWorkouts(int resultWorkoutsId)
        {
            var resultWorkoutRemove = await _context.ResultWorkouts.FirstOrDefaultAsync(b => b.Id == resultWorkoutsId);

            if (resultWorkoutRemove is null)
            {
                return false;
            }

            _context.ResultWorkouts.Remove(resultWorkoutRemove);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
