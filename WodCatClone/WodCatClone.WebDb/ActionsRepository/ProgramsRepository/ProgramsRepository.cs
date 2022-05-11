using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public class ProgramsRepository : IProgramsRepository
    {
        private readonly WodCatCloneContext _context;

        public ProgramsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Programs> GetAllPrograms()
        {
            return _context.Programs;
        }

        public IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id)
        {
            return _context.ProgramsWorkouts.Where(b => b.ProgramsId == id);
        }

        public Programs GetProgram(int id)
        {
            return _context.Programs.FirstOrDefault(b => b.Id == id);
        }
    }
}
