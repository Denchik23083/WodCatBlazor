using Microsoft.EntityFrameworkCore;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly WodCatCloneContext _context;

        public AuthRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public Task<User?> Login(User loginUser)
        {
            return _context.Users
                .Include(_ => _.Gender)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Programs)
                .ThenInclude(_ => _!.ProgramEmblem)
                .Include(_ => _.Events)
                .ThenInclude(_ => _!.EventEmblem)
                .FirstOrDefaultAsync(l => l.Email == loginUser.Email &&
                                     l.Password == loginUser.Password);
        }

        public async Task<bool> Register(User registerUser)
        {
            await _context.Users.AddAsync(registerUser);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
