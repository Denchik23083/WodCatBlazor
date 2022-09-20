using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

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

        public IEnumerable<User> GetAllHallsUsers(int id)
        {
            return _context.Users.Where(b => b.HallId == id);
        }

        public Halls GetHall(int hallId)
        {
            return _context.Halls.FirstOrDefault(b => b.Id == hallId);
        }

        public Halls GetHall(int? userHallId)
        {
            return _context.Halls.FirstOrDefault(b => b.Id == userHallId);
        }

        public HallEmblem GetImage(int? imageId)
        {
            return _context.HallEmblem.FirstOrDefault(b => b.Id == imageId);
        }

        public bool AddHall(Halls hall, User user)
        {
            hall.UserId = user.Id;

            _context.Halls.Add(hall);
            user.Points += 50;

            _context.SaveChanges();

            return true;
        }

        public bool EditHall(Halls hall, int hallId, User user)
        {
            var hallToEdit = _context.Halls.FirstOrDefault(b => b.Id == hallId);

            if (hallToEdit is null)
            {
                return false;
            }

            hallToEdit.Name = hall.Name;
            hallToEdit.Type = hall.Type;
            hallToEdit.Town = hall.Town;
            hallToEdit.Location = hall.Location;
            hallToEdit.Rating = hall.Rating;
            hallToEdit.Description = hall.Description;
            hallToEdit.EmblemHallId = hall.EmblemHallId;

            user.Points += 25;

            _context.SaveChanges();

            return true;
        }

        public bool RemoveHall(int hallId)
        {
            var hallToRemove = _context.Halls.FirstOrDefault(b => b.Id == hallId);

            if (hallToRemove is null)
            {
                return false;
            }

            _context.Halls.Remove(hallToRemove);
            _context.SaveChanges();

            var joinUserHall = _context.Users.Where(b => b.HallId == hallId);
            foreach (var item in joinUserHall)
            {
                item.HallId = null;
                _context.SaveChanges();
            }

            return true;
        }

        public bool JoinHall(int hallId, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = hallId;

            _context.SaveChanges();

            return true;
        }

        public bool ExitHall(int hallId, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = null;

            _context.SaveChanges();

            return true;
        }

        public int Athlete(int hallId)
        {
            return _context.Users.Count(b => b.HallId == hallId);
        }
    }
}
