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

        public async Task<IEnumerable<EventEmblem>> GetAllEventEmblem()
        {
            return await _context.EventEmblem.ToListAsync();
        }

        public async Task<Events?> GetEvent(int eventId)
        {
            return await _context.Events
                .Include(_ => _.EventEmblem)
                .Include(_ => _.EventTimeUsers)!
                .ThenInclude(_ => _.User)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.Gender)
                .Include(_ => _.Users)!
                .ThenInclude(_ => _.EventTimeUsers)
                .Include(_ => _.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Workouts)
                .ThenInclude(_ => _!.Halls)
                .ThenInclude(_ => _!.EmblemHall)
                .Include(_ => _.Workouts)
                .ThenInclude(_ => _!.ResultWorkouts)
                .Include(_ => _.Workouts)
                .ThenInclude(_ => _!.WorkoutsExercises)!
                .ThenInclude(_ => _.Exercises)
                .FirstOrDefaultAsync(b => b.Id == eventId);
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

        public async Task<bool> AutoRemoveEvent(IEnumerable<User?>? usersToList, Events eventToRemove)
        {
            var points = 200;

            if (usersToList is not null)
            {
                foreach (var user in usersToList)
                {
                    user!.Points += points;

                    points /= 2;
                }
            }

            _context.Events.Remove(eventToRemove);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> JoinEvent(User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExitEvent(User loginUser)
        {
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            await _context.EventTimeUser.AddAsync(eventTimeUser);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
