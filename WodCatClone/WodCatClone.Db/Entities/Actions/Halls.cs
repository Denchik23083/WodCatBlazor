namespace WodCatClone.Db.Entities.Actions
{
    public class Halls
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public int EmblemHallId { get; set; }

        public HallEmblem EmblemHall { get; set; }
    }
}
