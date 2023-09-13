using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        Task<IEnumerable<Halls>> GetAllHallsAsync();

        Task<IEnumerable<HallEmblem>> GetAllHallEmblemAsync();

        Task<Halls?> GetHallAsync(int hallId);

        Task<bool> AddHallAsync(Halls hall, User loginUser);

        Task<bool> EditHallAsync(Halls hallToEdit, User loginUser);

        Task<bool> RemoveHallAsync(Halls hallToRemove);

        Task<bool> JoinHallAsync(User user);

        Task<bool> ExitHallAsync(User user);
    }
}
