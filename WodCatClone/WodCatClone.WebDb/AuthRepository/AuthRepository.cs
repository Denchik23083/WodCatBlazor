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

        public User Login(Login login)
        {
            var user = _context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                          l.Password == login.Password);

            return user;
        }

        public bool Register(Register register)
        {
            var allUsers = _context.Users;
            var registerUser = Map(register);

            if (allUsers.Any(b => b.Email == registerUser.Email) 
                || allUsers.Any(b => b.NickName == registerUser.NickName))
            {
                return false;
            }

            registerUser.Country = "Ukraine";

            _context.Users.Add(registerUser);
            _context.SaveChanges();

            return true;
        }

        private User Map(Register model)
        {
            return new User
            {
                Name = model.Name,
                Surname = model.Surname,
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password,
                Birthday = model.Birthday,
                GenderId = model.GenderId
            };
        }
    }
}
