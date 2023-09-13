using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        Task<IEnumerable<Events>> GetAllEventsAsync();

        Task<IEnumerable<Events>> GetAllEndEventsAsync();

        Task<IEnumerable<EventEmblem>> GetAllEventEmblemAsync();

        Task<Events?> GetEventAsync(int eventId);

        Task<bool> AddEventAsync(Events @event);

        Task<bool> EditEventAsync(Events @event, int eventId);
        
        Task<bool> RemoveEventAsync(int eventId);

        Task<bool> AutoRemoveEventAsync(Events eventToRemove);

        Task<bool> JoinEventAsync(int eventId, User user);

        Task<bool> ExitEventAsync(int eventId, User user);

        Task<bool> AddEventTimeUserAsync(EventTimeUser eventTimeUser);
    }
}
