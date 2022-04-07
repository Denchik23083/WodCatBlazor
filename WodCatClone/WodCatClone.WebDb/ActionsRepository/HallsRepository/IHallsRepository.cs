using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        HallEmblem GetImage(int imageId);

        bool AddHall(Halls hall);
    }
}
