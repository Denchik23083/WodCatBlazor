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

        public Gender GetGender(int? id)
        {
            return _context.Gender.FirstOrDefault(b => b.Id == id);
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
