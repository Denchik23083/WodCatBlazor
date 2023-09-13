using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        Task<IEnumerable<Halls>> GetAllHallsAsync();

        Task<IEnumerable<HallEmblem>> GetAllHallEmblemAsync();

        Task<Halls?> GetHallAsync(int hallId);

        Task<bool> AddHallAsync(Halls hall);

        Task<bool> EditHallAsync(Halls hall, int hallId);

        Task<bool> RemoveHallAsync(int hallId);

        Task<bool> JoinHallAsync(int hallId, User user);

        Task<bool> ExitHallAsync(int hallId, User user);
    }
}
