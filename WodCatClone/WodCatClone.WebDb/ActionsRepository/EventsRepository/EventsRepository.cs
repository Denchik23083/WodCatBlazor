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
            return _context.EventTimeUser
                .Where(b => b.EventsId == eventId)
                .OrderByDescending(b => b.Time).Take(3);
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
            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

            @event.UserId = user.Id;

            var allEvent = _context.Events;

            if (allEvent.Any(b => b.Name == @event.Name))
            {
                return false;
            }

            _context.Events.Add(@event);

            user.Points += 100;
            _context.SaveChanges();

            return true;
        }

        public bool EditEvent(Events @event, int eventId)
        {
            var loginUser = UserRepository.UserRepository.User;
            var user = _context.Users.FirstOrDefault(b => b.Id == loginUser.Id);

            if (user is null)
            {
                return false;
            }

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

            user.Points += 50;
            _context.SaveChanges();

            return true;
        }

        public bool RemoveEvent(int eventId)
        {
            var allUsers = _context.Users;

            foreach (var allUser in allUsers)
            {
                allUser.EventId = null;
            }

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
            var allUsers = _context.Users;

            foreach (var allUser in allUsers)
            {
                allUser.EventId = null;
            }

            var allUsersTime = _context.EventTimeUser.OrderByDescending(b => b.Time).Take(3);

            var points = 200;

            foreach (var item in allUsersTime)
            {
                var user = _context.Users.FirstOrDefault(b => b.Id == item.Id);
                
                if (user is not null)
                {
                    user.Points += points;
                }

                points /= 2;
            }

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
