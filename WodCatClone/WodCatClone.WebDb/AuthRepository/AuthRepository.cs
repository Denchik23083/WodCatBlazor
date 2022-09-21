using System.Linq;
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

        public User Login(User loginUser)
        {
            return _context.Users.FirstOrDefault(l => l.Email == loginUser.Email &&
                                                      l.Password == loginUser.Password);
        }

        public bool Register(User registerUser)
        {
            var allUsers = _context.Users;

            if (allUsers.Any(b => b.Email.Equals(registerUser.Email)
                                  || b.NickName.Equals(registerUser.NickName)))
            {
                return false;
            }

            _context.Users.Add(registerUser);
            _context.SaveChanges();

            return true;
        }
    }
}
