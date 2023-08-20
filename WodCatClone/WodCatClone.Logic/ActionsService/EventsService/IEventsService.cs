﻿using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        Task<IEnumerable<Events>> GetAllEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId);

        IEnumerable<EventEmblem> GetAllEventEmblem();

        Events GetEvent(int eventId);

        EventTimeUser GetEventTimeUser(int eventId, int userId);

        string GetImage(int id);

        Task<bool> AddEvent(Events @event);

        Task<bool> EditEvent(Events @event, int eventId);
        
        bool RemoveEvent(int eventId);

        bool AutoRemoveEvent(int eventId);

        bool JoinEvent(int eventId, User user);

        bool ExitEvent(int eventId, User user);

        bool AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
