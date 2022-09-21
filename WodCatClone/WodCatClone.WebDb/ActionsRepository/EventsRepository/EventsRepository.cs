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

        public IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId)
        {
            return _context.EventTimeUser.Where(b => b.EventsId == eventId);
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

        public EventTimeUser GetEventTimeUser(int eventId, int userId)
        {
            return _context.EventTimeUser.FirstOrDefault(b => b.EventsId == eventId && b.UserId == userId);
        }

        public bool AddEvent(Events @event)
        {
            _context.Events.Add(@event);
            _context.SaveChanges();

            return true;
        }

        public bool EditEvent(Events @event, int eventId)
        {
            var eventToEdit = _context.Events.FirstOrDefault(b => b.Id == eventId);

            if (eventToEdit is null)
            {
                return false;
            }

            eventToEdit.Name = @event.Name;
            eventToEdit.Town = @event.Town;
            eventToEdit.TypeEvent = @event.TypeEvent;
            eventToEdit.TypeSport = @event.TypeSport;
            eventToEdit.Location = @event.Description;
            eventToEdit.StartDate = @event.StartDate;
            eventToEdit.EndDate = @event.EndDate;
            eventToEdit.EventsEmblemId = @event.EventsEmblemId;
            eventToEdit.HallId = @event.HallId;

            _context.SaveChanges();

            return true;
        }

        public bool RemoveEvent(int eventId)
        {
            var eventToRemove = _context.Events.FirstOrDefault(b => b.Id == eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            _context.Events.Remove(eventToRemove);
            _context.SaveChanges();

            return true;
        }

        public bool AutoRemoveEvent(int eventId)
        {
            var eventToRemove = _context.Events.FirstOrDefault(b => b.Id == eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            _context.Events.Remove(eventToRemove);
            _context.SaveChanges();

            return true;
        }

        public bool JoinEvent(int eventId, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = eventId;

            _context.SaveChanges();

            return true;
        }

        public bool ExitEvent(int eventId, User user)
        {
            var loginUser = _context.Users.FirstOrDefault(b => b.Id == user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = null;

            _context.SaveChanges();

            return true;
        }

        public bool AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            _context.EventTimeUser.Add(eventTimeUser);
            _context.SaveChanges();

            return true;
        }
    }
}
