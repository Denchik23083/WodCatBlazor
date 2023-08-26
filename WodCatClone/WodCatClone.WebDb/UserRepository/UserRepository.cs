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

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users
                .Include(_ => _.Gender)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .OrderBy(b => b.Points)
                .Reverse()
                .ToListAsync();
        }

        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await _context.Gender.ToListAsync();
        }

        public User GetUser(int? id)
        {
            return _context.Users
                .Include(_ => _.Gender)
                .FirstOrDefault(b => b.Id == id);
        }

        public async Task<User?> GetUser(string nickName)
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

        public Gender GetGender(int id)
        {
            return _context.Gender.FirstOrDefault(b => b.Id == id);
        }

        public bool EditUserHall(User loginUser, int id)
        {
            loginUser.HallId = id;

            _context.SaveChanges();

            return true;
        }

        public bool Update(User updateUser, User userToUpdate)
        {
            userToUpdate.Name = updateUser.Name;
            userToUpdate.Surname = updateUser.Surname;
            userToUpdate.Town = updateUser.Town;
            userToUpdate.HallId = updateUser.HallId;
            userToUpdate.GenderId = updateUser.GenderId;
            userToUpdate.Birthday = updateUser.Birthday;
            userToUpdate.Height = updateUser.Height;
            userToUpdate.Weight = updateUser.Weight;
            userToUpdate.AboutMe = updateUser.AboutMe;

            _context.SaveChanges();

            return true;
        }

        public bool UpdateAuth(User updateUser, User userToUpdate)
        {
            userToUpdate.NickName = updateUser.NickName;
            userToUpdate.Email = updateUser.Email;
            userToUpdate.Password = updateUser.Password;

            _context.SaveChanges();

            return true;
        }
    }
}
