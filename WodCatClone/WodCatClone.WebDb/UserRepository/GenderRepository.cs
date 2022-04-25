using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public class GenderRepository : IGenderRepository
    {
        private readonly WodCatCloneContext _context;

        public GenderRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public Gender GetGenderImage(int? id)
        {
            return _context.Gender.FirstOrDefault(b => b.Id == id);
        }

        public Gender GetGender(int? id)
        {
            return _context.Gender.FirstOrDefault(b => b.Id == id);
        }
    }
}
