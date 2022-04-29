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

        public bool AddHall(Halls hall)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is not null)
            {
                user.Points += 50;
            }

            hall.UserId = user!.Id;

            _context.Halls.Add(hall);
            _context.SaveChanges();

            return true;
        }

        public bool EditHall(Halls hall, int hallId)
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

            return true;
        }

        public void Athlete(IEnumerable<User> users, int hallId)
        {
            var hallUsers = users.Count(b => b.HallId == hallId);

            var hall = _context.Halls.FirstOrDefault(b => b.Id == hallId);

            hall!.Athletes = hallUsers;

            _context.SaveChanges();
        }
    }
}
