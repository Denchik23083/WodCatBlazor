using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        Task<IEnumerable<Events>> GetAllEvents();

        Task<IEnumerable<Events>> GetAllEndEvents();

        Task<IEnumerable<EventEmblem>> GetAllEventEmblem();

        Task<Events?> GetEvent(int eventId);

        Task<bool> AddEvent(Events @event, User loginUser);

        Task<bool> EditEvent(Events eventToEdit, User loginUser);

        Task<bool> RemoveEvent(Events eventToRemove);

        Task<bool> AutoRemoveEvent(IEnumerable<User?>? usersToList, Events eventToRemove);
        
        Task<bool> JoinEvent(User user);

        Task<bool> ExitEvent(User user);

        Task<bool> AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
