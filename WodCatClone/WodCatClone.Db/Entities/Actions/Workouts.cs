namespace WodCatClone.Db.Entities.Actions
{
    public class Workouts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Rating { get; set; }

        public string Category { get; set; }

        public string Complexity { get; set; }

        public string Movement { get; set; }

        public string Modality { get; set; }

        public string Inventory { get; set; }
        
        public string Minutes { get; set; }

        public string Seconds { get; set; }

        public string Exercises { get; set; }

        public int EmblemHallId { get; set; }

        public HallEmblem EmblemHall { get; set; }
    }
}
