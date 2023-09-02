using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        Task<IEnumerable<Halls>> GetAllHalls();

        Task<IEnumerable<HallEmblem>> GetAllHallEmblem();

        Task<Halls?> GetHall(int hallId);

        Halls GetHall(int? userHallId);

        HallEmblem GetImage(int? imageId);

        Task<bool> AddHall(Halls hall, User loginUser);

        Task<bool> EditHall(Halls hallToEdit, User loginUser);

        Task<bool> RemoveHall(Halls hallToRemove);

        Task<bool> JoinHall(User user);

        Task<bool> ExitHall(User user);

        Task<int> Athlete(int hallId);
    }
}
