using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.EventsRepository
{
    public interface IEventsRepository
    {
        IEnumerable<Events> GetAllEvents();

        EventEmblem GetImage(int id);
    }
}
