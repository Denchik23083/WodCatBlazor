using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public class EventsRepository : IEventsRepository
    {
        private readonly WodCatCloneContext _context;

        public EventsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Events> GetAllEvents()
        {
            return _context.Events;
        }

        public EventEmblem GetImage(int id)
        {
            return _context.EventEmblem.FirstOrDefault(b => b.Id == id);
        }
    }
}
