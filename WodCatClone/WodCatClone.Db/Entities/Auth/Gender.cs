using WodCatClone.Core;

namespace WodCatClone.Db.Entities.Auth
{
    public class Gender
    {
        public int Id { get; set; }

        public GenderType? Type { get; set; }

        public string? Image { get; set; }
    }
}
