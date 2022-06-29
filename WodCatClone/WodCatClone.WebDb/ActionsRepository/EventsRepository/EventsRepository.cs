using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public class EventsRepository : IEventsRepository
    {
        private readonly WodCatCloneContext _context;

        public EventsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Events> GetAllEvents()
        {
            return _context.Events;
        }

        public IEnumerable<User> GetAllEventsUsers(int id)
        {
            return _context.Users.Where(b => b.EventId == id);
        }

        public IEnumerable<EventEmblem> GetAllEventEmblem()
        {
            return _context.EventEmblem;
        }

        public Events GetEvent(int eventId)
        {
            return _context.Events.FirstOrDefault(b => b.Id == eventId);
        }

        public EventEmblem GetImage(int id)
        {
            return _context.EventEmblem.FirstOrDefault(b => b.Id == id);
        }

        public bool AddEvent(Events @event)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            @event.UserId = user.Id;

            _context.Events.Add(@event);
            user.Points += 100;

            _context.SaveChanges();

            return true;
        }
    }
}
