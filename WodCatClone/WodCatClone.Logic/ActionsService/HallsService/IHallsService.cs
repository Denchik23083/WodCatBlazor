using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Halls GetHall(int hallId);

        Halls GetHall(int? userHallId);

        string GetImage(int? imageId);

        bool AddHall(Halls hall);

        bool EditHall(Halls hall, int hallId);

        bool RemoveHall(int hallId);

        int Athlete(int hallId);
    }
}
