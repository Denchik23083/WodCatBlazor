using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        Task<IEnumerable<Events>> GetAllEventsAsync();

        Task<IEnumerable<Events>> GetAllEndEventsAsync();

        Task<IEnumerable<EventEmblem>> GetAllEventEmblemAsync();

        Task<Events?> GetEventAsync(int eventId);

        Task<bool> AddEventAsync(Events @event, User loginUser);

        Task<bool> EditEventAsync(Events eventToEdit, User loginUser);

        Task<bool> RemoveEventAsync(Events eventToRemove);

        Task<bool> AutoRemoveEventAsync(IEnumerable<User?>? usersToList, Events eventToRemove);
        
        Task<bool> JoinEventAsync(User user);

        Task<bool> ExitEventAsync(User user);

        Task<bool> AddEventTimeUserAsync(EventTimeUser eventTimeUser);
    }
}
