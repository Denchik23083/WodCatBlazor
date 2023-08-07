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

        public bool AddEvent(Events @event, User user)
        {
            @event.UserId = user.Id;

            _context.Events.Add(@event);

            user.Points += 100;

            _context.SaveChanges();

            return true;
        }

        public bool EditEvent(Events @event, Events eventToEdit, User user)
        {
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

        public bool RemoveEvent(IEnumerable<User> allUsers, Events eventToRemove)
        {
            foreach (var user in allUsers)
            {
                user.EventId = null;
            }

            _context.Events.Remove(eventToRemove);
            _context.SaveChanges();

            return true;
        }

        public bool AutoRemoveEvent(IEnumerable<User> allUsers, IEnumerable<User> usersToList, Events eventToRemove)
        {
            foreach (var user in allUsers)
            {
                user.EventId = null;
            }

            var points = 200;

            foreach (var user in usersToList)
            {
                user.Points += points;

                points /= 2;
            }

            _context.Events.Remove(eventToRemove);
            _context.SaveChanges();

            return true;
        }

        public bool JoinEvent(int eventId, User loginUser)
        {
            loginUser.EventId = eventId;

            _context.SaveChanges();

            return true;
        }

        public bool ExitEvent(int eventId, User loginUser)
        {
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
