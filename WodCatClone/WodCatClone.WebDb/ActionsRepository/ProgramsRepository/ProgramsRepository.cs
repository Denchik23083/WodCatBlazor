using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.ProgramsRepository
{
    public class ProgramsRepository : IProgramsRepository
    {
        private readonly WodCatCloneContext _context;

        public ProgramsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Programs>> GetAllPrograms()
        {
            return await _context.Programs
                .Include(_ => _.ProgramsWorkouts)!
                .ThenInclude(_ => _.Workouts)
                .ThenInclude(_ => _!.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .Include(_ => _.ProgramEmblem)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Users)
                .ToListAsync();
        }

        public IEnumerable<ProgramsWorkouts> GetAllProgramsWorkouts(int id)
        {
            return _context.ProgramsWorkouts.Where(b => b.ProgramsId == id);
        }

        public IEnumerable<User> GetAllProgramsUsers(int id)
        {
            return _context.Users.Where(b => b.ProgramId == id);
        }

        public ProgramTimeUser GetProgramTimeUser(int programId, User user)
        {
            return _context.ProgramTimeUser.FirstOrDefault(b => b.ProgramsId == programId && b.UserId == user.Id);
        }

        public Programs GetProgram(int id)
        {
            return _context.Programs.FirstOrDefault(b => b.Id == id);
        }

        public Programs GetProgram(int? id)
        {
            return _context.Programs.FirstOrDefault(b => b.Id == id);
        }

        public ProgramEmblem GetImage(int? programsEmblemId)
        {
            return _context.ProgramEmblem.FirstOrDefault(b => b.Id == programsEmblemId);
        }

        public bool BeginProgram(int id, User loginUser, ProgramTimeUser programTimeUser, ProgramTimeUser newProgramTimeUser)
        {
            loginUser.ProgramId = id;

            if (programTimeUser is not null)
            {
                _context.ProgramTimeUser.Remove(programTimeUser);
            }

            _context.ProgramTimeUser.Add(newProgramTimeUser);
            _context.SaveChanges();

            return true;
        }

        public bool StopProgram(int id, User loginUser, ProgramTimeUser programTimeUser, bool isFinish)
        {
            loginUser.ProgramId = null;

            if (isFinish)
            {
                loginUser.Points += 50;
            }

            _context.ProgramTimeUser.Remove(programTimeUser);
            _context.SaveChanges();

            return true;
        }
    }
}
