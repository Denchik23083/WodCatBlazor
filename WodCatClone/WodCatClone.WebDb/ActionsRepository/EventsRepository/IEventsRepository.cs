﻿using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        Task<IEnumerable<Events>> GetAllEvents();

        Task<IEnumerable<Events>> GetAllEndEvents();

        IEnumerable<User> GetAllEventsUsers(int id);

        IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId);

        IEnumerable<EventEmblem> GetAllEventEmblem();

        Events GetEvent(int eventId);

        EventEmblem GetImage(int id);

        EventTimeUser GetEventTimeUser(int eventId, int userId);

        bool AddEvent(Events @event, User user);

        bool EditEvent(Events @event, Events eventToEdit, User user);

        bool RemoveEvent(IEnumerable<User> allUsers, Events eventToRemove);

        bool AutoRemoveEvent(IEnumerable<User> allUsers, IEnumerable<User> usersToList, Events eventToRemove);

        Task RemoveEndEvents(IEnumerable<Events> endEvents);

        bool JoinEvent(int eventId, User user);

        bool ExitEvent(int eventId, User user);

        bool AddEventTimeUser(EventTimeUser eventTimeUser);
    }
}
