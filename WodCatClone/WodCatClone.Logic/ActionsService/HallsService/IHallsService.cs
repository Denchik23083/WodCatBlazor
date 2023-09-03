using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        Task<IEnumerable<Halls>> GetAllHalls();

        Task<IEnumerable<HallEmblem>> GetAllHallEmblem();

        Task<Halls?> GetHall(int hallId);

        Task<bool> AddHall(Halls hall);

        Task<bool> EditHall(Halls hall, int hallId);

        Task<bool> RemoveHall(int hallId);

        Task<bool> JoinHall(int hallId, User user);

        Task<bool> ExitHall(int hallId, User user);
    }
}
