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

            if (User is null)
            {
                return User;
            }

            return _context.Users.FirstOrDefault(b => b.Id == User.Id);
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

        public Gender GetGender(string gender)
        {
            return _context.Gender.FirstOrDefault(b => b.Name == gender);
        }

        public bool EditUserHall(User user, int id)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = id;
            _context.SaveChanges();

            return true;
        }

        public bool EditUserProgram(User user, int id)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.ProgramId = id;
            _context.SaveChanges();

            return true;
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

        public bool UpdateAuth(User updateUser, int id)
        {
            var userToUpdate = _context.Users.FirstOrDefault(b => b.Id == id);

            if (userToUpdate is null)
            {
                return false;
            }

            var allUsers = _context.Users;

            if (allUsers.Any(b => b.Email == updateUser.Email) && userToUpdate.Email != updateUser.Email)
            {
                if (allUsers.Any(b => b.NickName == updateUser.NickName) && userToUpdate.NickName != updateUser.NickName)
                {
                    return false;
                }
            }

            userToUpdate.NickName = updateUser.NickName;
            userToUpdate.Email = updateUser.Email;
            userToUpdate.Password = updateUser.Password;

            User = userToUpdate;

            _context.SaveChanges();

            return true;
        }
    }
}
