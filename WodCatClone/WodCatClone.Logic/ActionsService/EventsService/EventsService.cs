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

        public IEnumerable<EventEmblem> GetAllEventEmblem()
        {
            return _repository.GetAllEventEmblem();
        }

        public Events GetEvent(int eventId)
        {
            return _repository.GetEvent(eventId);
        }

        public string GetImage(int id)
        {
            var eventEmblem = _repository.GetImage(id);

            return eventEmblem.Image;
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
    }
}
