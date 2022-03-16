using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Exercises> GetAllExercises()
        {
            return _context.Exercises;
        }

        public Exercises GetExercise(int exerciseId)
        {
            return _context.Exercises.FirstOrDefault(x => x.Id == exerciseId);
        }
    }
}
