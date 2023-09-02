using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        Task<IEnumerable<Events>> GetAllEvents();

        Task<IEnumerable<Events>> GetAllEndEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId);

        Task<IEnumerable<EventEmblem>> GetAllEventEmblem();

        Task<Events?> GetEvent(int eventId);

        EventTimeUser GetEventTimeUser(int eventId, int userId);

        Task<bool> AddEvent(Events @event, User loginUser);

        Task<bool> EditEvent(Events eventToEdit, User loginUser);

        Task<bool> RemoveEvent(Events eventToRemove);

        bool AutoRemoveEvent(IEnumerable<User> allUsers, IEnumerable<User> usersToList, Events eventToRemove);

        Task RemoveEndEvents(IEnumerable<Events> endEvents);

        bool JoinEvent(int eventId, User user);

        bool ExitEvent(int eventId, User user);

        bool AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
