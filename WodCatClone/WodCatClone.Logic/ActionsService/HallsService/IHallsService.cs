using System.Collections.Generic;
using System.Threading.Tasks;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public interface IHallsService
    {
        Task<IEnumerable<Halls>> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        IEnumerable<User> GetAllHallsUsers(int id);

        Halls GetHall(int hallId);

        Task<Halls> GetHall(int? userHallId);

        Task<string> GetImage(int? imageId);

        bool AddHall(Halls hall);

        bool EditHall(Halls hall, int hallId);

        bool RemoveHall(int hallId);

        bool JoinHall(int hallId, User user);

        bool ExitHall(int hallId, User user);

        int Athlete(int hallId);
    }
}
