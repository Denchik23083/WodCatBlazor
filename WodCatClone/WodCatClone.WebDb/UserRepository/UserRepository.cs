using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly WodCatCloneContext _context;
        public static User User;

        public UserRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.OrderBy(b => b.Points).Reverse();
        }

        public User GetUser(User user)
        {
            User = user;
            
            return User;
        }

        public User GetUser(int? id)
        {
            return _context.Users.FirstOrDefault(b => b.Id == id);
        }

        public User GetUser(string nickName)
        {
            return _context.Users.FirstOrDefault(b => b.NickName == nickName);
        }

        public bool Update(User editUser, int id)
        {
            var userToUpdate = _context.Users.FirstOrDefault(b => b.Id == id);

            if (userToUpdate is null)
            {
                return false;
            }

            userToUpdate.Name = editUser.Name;
            userToUpdate.Surname = editUser.Surname;
            userToUpdate.Town = editUser.Town;
            userToUpdate.HallId = editUser.HallId;
            userToUpdate.GenderId = editUser.GenderId;
            userToUpdate.Birthday = editUser.Birthday;
            userToUpdate.Height = editUser.Height;
            userToUpdate.Weight = editUser.Weight;
            userToUpdate.AboutMe = editUser.AboutMe;

            _context.SaveChanges();

            return true;
        }

        public void Join(int hallId)
        {
            var user = _context.Users.FirstOrDefault(b => b.Id == User.Id);

            user!.HallId = hallId;

            _context.SaveChanges();
        }
        
        public void Exit(int hallId)
        {
            var user = _context.Users.FirstOrDefault(b => b.Id == User.Id);

            user!.HallId = null;

            _context.SaveChanges();
        }
    }
}
