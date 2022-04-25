namespace WodCatClone.Logic.UserService
{
    public interface IGenderService
    {
        string GetGenderImage(int? id);

        string GetGender(int? id);
    }
}
