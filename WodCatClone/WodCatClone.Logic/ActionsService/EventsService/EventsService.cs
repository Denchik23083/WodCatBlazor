using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public class EventsService : IEventsService
    {
        private readonly IEventsRepository _repository;

        public EventsService(IEventsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Events> GetAllEvents()
        {
            return _repository.GetAllEvents();
        }

        public IEnumerable<User> GetAllEventsUsers(int id)
        {
            return _repository.GetAllEventsUsers(id);
        }

        public IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId)
        {
            return _repository.GetAllEventTimeUsers(eventId);
        }

        public IEnumerable<EventEmblem> GetAllEventEmblem()
        {
            return _repository.GetAllEventEmblem();
        }

        public Events GetEvent(int eventId)
        {
            return _repository.GetEvent(eventId);
        }

        public EventTimeUser GetEventTimeUser(int eventId, int userId)
        {
            return _repository.GetEventTimeUser(eventId, userId);
        }

        public string GetImage(int id)
        {
            return _repository.GetImage(id).Image;
        }

        public bool AddEvent(Events @event)
        {
            return _repository.AddEvent(@event);
        }

        public bool EditEvent(Events @event, int eventId)
        {
            return _repository.EditEvent(@event, eventId);
        }

        public bool RemoveEvent(int eventId)
        {
            return _repository.RemoveEvent(eventId);
        }

        public bool AutoRemoveEvent(int eventId)
        {
            return _repository.AutoRemoveEvent(eventId);
        }

        public bool JoinEvent(int eventId, User user)
        {
            AuthService.AuthService.User.EventId = eventId;

            return _repository.JoinEvent(eventId, user);
        }

        public bool ExitEvent(int eventId, User user)
        {
            AuthService.AuthService.User.EventId = null;

            return _repository.ExitEvent(eventId, user);
        }

        public bool AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            return _repository.AddEventTimeUser(eventTimeUser);
        }
    }
}
