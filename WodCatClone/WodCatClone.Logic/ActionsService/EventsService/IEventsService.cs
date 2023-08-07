using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        IEnumerable<Events> GetAllEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId);

        IEnumerable<EventEmblem> GetAllEventEmblem();

        Events GetEvent(int eventId);

        EventTimeUser GetEventTimeUser(int eventId, int userId);

        string GetImage(int id);

        bool AddEvent(Events @event);

        bool EditEvent(Events @event, int eventId);
        
        bool RemoveEvent(int eventId);

        bool AutoRemoveEvent(int eventId);

        bool JoinEvent(int eventId, User user);

        bool ExitEvent(int eventId, User user);

        bool AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
