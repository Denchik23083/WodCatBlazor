using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        IEnumerable<User> GetAllHallsUsers(int id);

        Halls GetHall(int hallId);

        Halls GetHall(int? userHallId);

        string GetImage(int? imageId);

        Task<bool> AddHall(Halls hall);

        Task<bool> EditHall(Halls hall, int hallId);

        bool RemoveHall(int hallId);

        bool JoinHall(int hallId, User user);

        bool ExitHall(int hallId, User user);

        int Athlete(int hallId);
    }
}
