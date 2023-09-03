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
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .ToListAsync();
        }

        public async Task<Programs?> GetProgram(int id)
        {
            return await _context.Programs
                .Include(_ => _.Users)
                .Include(_ => _.ProgramEmblem)
                .Include(_ => _.ProgramsWorkouts)!
                .ThenInclude(_ => _.Workouts)
                .ThenInclude(_ => _!.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .Include(_ => _.ProgramTimeUsers)!
                .ThenInclude(_ => _.User)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> BeginProgram(User loginUser, ProgramTimeUser? programTimeUser, ProgramTimeUser newProgramTimeUser)
        {
            if (programTimeUser is not null)
            {
                _context.ProgramTimeUser.Remove(programTimeUser);
            }

            await _context.ProgramTimeUser.AddAsync(newProgramTimeUser);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> StopProgram(User loginUser, ProgramTimeUser? programTimeUser, bool isFinish)
        {
            if (isFinish)
            {
                loginUser.Points += 50;
            }

            _context.ProgramTimeUser.Remove(programTimeUser!);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
