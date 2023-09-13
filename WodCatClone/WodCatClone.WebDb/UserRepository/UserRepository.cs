using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly WodCatCloneContext _context;

        public UserRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(_ => _.Gender)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Programs)
                .ThenInclude(_ => _!.ProgramEmblem)
                .Include(_ => _.Events)
                .ThenInclude(_ => _!.EventEmblem)
                .OrderBy(b => b.Points)
                .Reverse()
                .ToListAsync();
        }

        public async Task<IEnumerable<Gender>> GetAllGendersAsync()
        {
            return await _context.Gender.ToListAsync();
        }

        public async Task<User?> GetUserAsync(int id)
        {
            return await _context.Users
                .Include(_ => _.ProgramTimeUsers)!
                .ThenInclude(_ => _.Programs)
                .Include(_ => _.Gender)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Programs)
                .ThenInclude(_ => _!.ProgramEmblem)
                .Include(_ => _.Events)
                .ThenInclude(_ => _!.EventEmblem)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<User?> GetUserAsync(string nickName)
        {
            return await _context.Users
                .Include(_ => _.Gender)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Programs)
                .ThenInclude(_ => _!.ProgramEmblem)
                .Include(_ => _.Events)
                .ThenInclude(_ => _!.EventEmblem)
                .FirstOrDefaultAsync(b => b.NickName!.Equals(nickName));
        }

        public async Task<bool> EditUserHallAsync(User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(User userToUpdate)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAuthAsync(User userToUpdate)
        {
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
