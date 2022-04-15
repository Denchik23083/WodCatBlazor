using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public class HallsRepository : IHallsRepository
    {
        private readonly WodCatCloneContext _context;

        public HallsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Halls> GetAllHalls()
        {
            return _context.Halls;
        }

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _context.HallEmblem;
        }

        public Halls GetHall(int hallId)
        {
            return _context.Halls.FirstOrDefault(b => b.Id == hallId);
        }

        public HallEmblem GetImage(int? imageId)
        {
            return _context.HallEmblem.FirstOrDefault(b => b.Id == imageId);
        }

        public bool AddHall(Halls hall)
        {
            _context.Halls.Add(hall);

            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is not null)
            {
                user.Points += 50;
            }

            _context.SaveChanges();

            return true;
        }

        public bool AddAthlete(int hallId)
        {
            var hall = _context.Halls.FirstOrDefault(b => b.Id == hallId);

            if (hall is null)
            {
                return false;
            }

            hall.Athletes += 1;

            _context.SaveChanges();

            return true;
        }
    }
}
