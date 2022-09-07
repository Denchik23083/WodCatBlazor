using System.Linq;
using System.Threading.Tasks;
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

        public async Task<User> Login(Login login)
        {
<<<<<<< HEAD
            return _context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                      l.Password == login.Password);
=======
            var user = await _context.Users.FirstOrDefaultAsync(l => l.Email == login.Email &&
                                                          l.Password == login.Password);

            return user;
>>>>>>> main
        }

        public async Task<bool> Register(Register register)
        {
            var allUsers = await _context.Users.ToListAsync();
            var registerUser = Map(register);

            if (allUsers.Any(b => b.Email == registerUser.Email) 
                || allUsers.Any(b => b.NickName == registerUser.NickName))
            {
                return false;
            }

            registerUser.Country = "Ukraine";

            await _context.Users.AddAsync(registerUser);
            await _context.SaveChangesAsync();

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
                GenderId = model.GenderId,
                Town = model.Town
            };
        }
    }
}
