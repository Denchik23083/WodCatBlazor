using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        IEnumerable<Events> GetAllEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventEmblem> GetAllEventEmblem();

        Events GetEvent(int eventId);

        EventEmblem GetImage(int id);

        bool AddEvent(Events @event);

        bool EditEvent(Events @event, int eventId);
        
        bool RemoveEvent(int eventId);
    }
}
