using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Halls GetHall(int hallId);

        HallEmblem GetImage(int? imageId);

        bool AddHall(Halls hall);

        bool AddAthlete(int hallId);
    }
}
