using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class Halls
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Town { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public int Athletes { get; set; }

        public int? EmblemHallId { get; set; }

        public HallEmblem EmblemHall { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }
    }
}
