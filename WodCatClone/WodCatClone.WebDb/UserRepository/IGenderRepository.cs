using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.UserRepository
{
    public interface IGenderRepository
    {
        Gender GetGenderImage(int? id);

        Gender GetGender(int? id);
    }
}
