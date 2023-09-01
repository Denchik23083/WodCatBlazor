using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Events>> GetAllEvents()
        {
            return await _context.Events
                .Include(_ => _.EventEmblem)
                .Include(_ => _.Halls)
                .Include(_ => _.Workouts)
                .Include(_ => _.EventTimeUsers)!
                .ThenInclude(_ => _.User)
                .ThenInclude(_ => _!.Gender)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .Where(_ => _.EndDate > DateTime.Now)
                .ToListAsync();
        }

        public async Task<IEnumerable<Events>> GetAllEndEvents()
        {
            return await _context.Events
                .Include(_ => _.EventEmblem)
                .Include(_ => _.Halls)
                .Include(_ => _.Workouts)
                .Include(_ => _.EventTimeUsers)!
                .ThenInclude(_ => _.User)
                .ThenInclude(_ => _!.Gender)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .Where(_ => _.EndDate < DateTime.Now)
                .ToListAsync();
        }

        public IEnumerable<User> GetAllEventsUsers(int id)
        {
            return _context.Users.Where(b => b.EventId == id);
        }

        public IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId)
        {
            return _context.EventTimeUser.Where(b => b.EventsId == eventId);
        }

        public async Task<IEnumerable<EventEmblem>> GetAllEventEmblem()
        {
            return await _context.EventEmblem.ToListAsync();
        }

        public Events GetEvent(int eventId)
        {
            return _context.Events.FirstOrDefault(b => b.Id == eventId);
        }

        public EventTimeUser GetEventTimeUser(int eventId, int userId)
        {
            return _context.EventTimeUser.FirstOrDefault(b => b.EventsId == eventId && b.UserId == userId);
        }

        public async Task<bool> AddEvent(Events @event, User loginUser)
        {
            await _context.Events.AddAsync(@event);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditEvent(Events eventToEdit, User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveEvent(Events eventToRemove)
        {
            _context.Events.Remove(eventToRemove);
            await _context.SaveChangesAsync();

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

        public async Task RemoveEndEvents(IEnumerable<Events> endEvents)
        {
            _context.Events.RemoveRange(endEvents);

            await _context.SaveChangesAsync();
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
