using System.Collections.Generic;

namespace WodCatClone.Db.Entities.Actions
{
    public class Exercises
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FullDescription { get; set; }

        public string Complexity { get; set; }

        public string Movement { get; set; }

        public string Modality { get; set; }

        public string Inventory { get; set; }

        public string Image { get; set; }

        public List<WorkoutsExercises> WorkoutsExercises { get; set; }
    }
}
