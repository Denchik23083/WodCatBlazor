using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public interface IHallsRepository
    {
        IEnumerable<Halls> GetAllHalls();

        IEnumerable<HallEmblem> GetAllHallEmblem();

        IEnumerable<User> GetAllHallsUsers(int id);

        Halls GetHall(int hallId);

        Halls GetHall(int? userHallId);

        HallEmblem GetImage(int? imageId);

        bool AddHall(Halls hall, User user);

        bool EditHall(Halls hall, Halls hallToEdit, User user);

        bool RemoveHall(IEnumerable<User> joinUserHall, Halls hallToRemove);

        bool JoinHall(int hallId, User user);

        bool ExitHall(int hallId, User user);

        int Athlete(int hallId);
    }
}
