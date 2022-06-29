using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        IEnumerable<Events> GetAllEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventEmblem> GetAllEventEmblem();

        Events GetEvent(int eventId);

        string GetImage(int id);

        bool AddEvent(Events @event);
    }
}
