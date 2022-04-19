using System.Collections.Generic;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Halls GetHall(int hallId);

        Halls GetHall(int? userHallId);

        HallEmblem GetImage(int? imageId);

        bool AddHall(Halls hall);

        bool EditHall(Halls hall, int hallId);

        bool RemoveHall(int hallId);

        void AddAthlete(int hallId);

        void RemoveAthlete(int hallId);
    }
}
