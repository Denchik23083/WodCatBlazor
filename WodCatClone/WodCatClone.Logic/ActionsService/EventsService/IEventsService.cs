using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public interface IEventsService
    {
        IEnumerable<Events> GetAllEvents();
    }
}
