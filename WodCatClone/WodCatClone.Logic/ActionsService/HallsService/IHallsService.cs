using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        IEnumerable<Halls> GetAllHalls();
    }
}
