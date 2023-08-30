using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        Task<IEnumerable<Halls>> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        Task<Halls?> GetHall(int hallId);

        Halls GetHall(int? userHallId);

        string GetImage(int? imageId);

        Task<bool> AddHall(Halls hall);

        Task<bool> EditHall(Halls hall, int hallId);

        Task<bool> RemoveHall(int hallId);

        Task<bool> JoinHall(int hallId, User user);

        Task<bool> ExitHall(int hallId, User user);

        Task<int> Athlete(int hallId);
    }
}
