using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        Task<IEnumerable<Events>> GetAllEvents();

        Task<IEnumerable<EventEmblem>> GetAllEventEmblem();

        Task<Events?> GetEvent(int eventId);

        EventTimeUser GetEventTimeUser(int eventId, int userId);

        Task<bool> AddEvent(Events @event);

        Task<bool> EditEvent(Events @event, int eventId);
        
        Task<bool> RemoveEvent(int eventId);

        Task<bool> AutoRemoveEvent(int eventId);

        Task<bool> JoinEvent(int eventId, User user);

        Task<bool> ExitEvent(int eventId, User user);

        Task<bool> AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
