using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;
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

        public string GetImage(int id)
        {
            var eventEmblem = _repository.GetImage(id);

            return eventEmblem.Image;
        }
    }
}
