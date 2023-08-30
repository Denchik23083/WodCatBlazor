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

        public async Task<IEnumerable<Halls>> GetAllHalls()
        {
            return await _context.Halls
                .Include(_ => _.EmblemHall)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .ToListAsync();
        }

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _context.HallEmblem;
        }

        public async Task<Halls?> GetHall(int hallId)
        {
            return await _context.Halls
                .Include(_ => _.EmblemHall)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .FirstOrDefaultAsync(b => b.Id == hallId);
        }

        public Halls GetHall(int? userHallId)
        {
            return _context.Halls.FirstOrDefault(b => b.Id == userHallId);
        }

        public HallEmblem GetImage(int? imageId)
        {
            return _context.HallEmblem.FirstOrDefault(b => b.Id == imageId);
        }

        public bool AddHall(Halls hall, User user)
        {
            hall.UserId = user.Id;

            _context.Halls.Add(hall);

            user.Points += 50;

            _context.SaveChanges();

            return true;
        }

        public bool EditHall(Halls hall, Halls hallToEdit, User user)
        {
            hallToEdit.Name = hall.Name;
            hallToEdit.Type = hall.Type;
            hallToEdit.Town = hall.Town;
            hallToEdit.Location = hall.Location;
            hallToEdit.Rating = hall.Rating;
            hallToEdit.Description = hall.Description;
            hallToEdit.EmblemHallId = hall.EmblemHallId;

            user.Points += 25;

            _context.SaveChanges();

            return true;
        }

        public bool RemoveHall(Halls hallToRemove)
        {
            _context.Halls.Remove(hallToRemove);
            _context.SaveChanges();

            return true;
        }

        public async Task<bool> JoinHall(int hallId, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExitHall(int hallId, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<int> Athlete(int hallId)
        {
            return await _context.Users.CountAsync(b => b.HallId == hallId);
        }
    }
}
