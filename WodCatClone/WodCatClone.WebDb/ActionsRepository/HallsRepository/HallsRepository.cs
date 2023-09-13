using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public class HallsRepository : IHallsRepository
    {
        private readonly WodCatCloneContext _context;

        public HallsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Halls>> GetAllHallsAsync()
        {
            return await _context.Halls
                .Include(_ => _.EmblemHall)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .ToListAsync();
        }

        public async Task<IEnumerable<HallEmblem>> GetAllHallEmblemAsync()
        {
            return await _context.HallEmblem.ToListAsync();
        }

        public async Task<Halls?> GetHallAsync(int hallId)
        {
            return await _context.Halls
                .Include(_ => _.EmblemHall)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .FirstOrDefaultAsync(b => b.Id == hallId);
        }

        public async Task<bool> AddHallAsync(Halls hall, User loginUser)
        {
            await _context.Halls.AddAsync(hall);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditHallAsync(Halls hallToEdit, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveHallAsync(Halls hallToRemove)
        {
            _context.Halls.Remove(hallToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> JoinHallAsync(User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExitHallAsync(User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
