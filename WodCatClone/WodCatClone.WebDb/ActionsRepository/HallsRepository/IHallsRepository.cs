using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        Task<IEnumerable<Halls>> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Task<Halls?> GetHall(int hallId);

        Halls GetHall(int? userHallId);

        HallEmblem GetImage(int? imageId);

        bool AddHall(Halls hall, User user);

        bool EditHall(Halls hall, Halls hallToEdit, User user);

        bool RemoveHall(Halls hallToRemove);

        Task<bool> JoinHall(int hallId, User user);

        Task<bool> ExitHall(int hallId, User user);

        Task<int> Athlete(int hallId);
    }
}
