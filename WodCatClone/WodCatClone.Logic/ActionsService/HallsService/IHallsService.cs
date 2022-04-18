using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Halls GetHall(int hallId);

        string GetImage(int? imageId);

        bool AddHall(Halls hall);

        bool EditHall(Halls hall, int hallId);

        bool RemoveHall(int hallId);

        void AddAthlete(int hallId);

        void RemoveAthlete(int hallId);
    }
}
