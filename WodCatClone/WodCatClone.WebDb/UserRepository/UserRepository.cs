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

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public async Task<User?> GetUser(User user)
        {
            return await _context.Users
                .Include(_ => _.Gender)
                .FirstOrDefaultAsync(b => b.Id == user!.Id);
        }

        public User GetUser(int? id)
        {
            return _context.Users.FirstOrDefault(b => b.Id == id);
        }

        public User GetUser(string nickName)
        {
            return _context.Users.FirstOrDefault(b => b.NickName.Equals(nickName));
        }

        public Gender GetGender(int? id)
        {
            return _context.Gender.FirstOrDefault(b => b.Id == id);
        }

        public Gender GetGender(string gender)
        {
            return _context.Gender.FirstOrDefault(b => b.Name.Equals(gender));
        }

        public bool EditUserHall(User loginUser, int id)
        {
            loginUser.HallId = id;

            _context.SaveChanges();

            return true;
        }

        public bool Update(User updateUser, User userToUpdate, Gender gender)
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
            userToUpdate.GenderId = gender.Id;

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
