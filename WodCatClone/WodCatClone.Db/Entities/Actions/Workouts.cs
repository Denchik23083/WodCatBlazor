using System.Collections.Generic;

namespace WodCatClone.Db.Entities.Actions
{
    public class Workouts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Rating { get; set; }

        public string Category { get; set; }

        public string Complexity { get; set; }

        public string Modality { get; set; }
        
        public string Minutes { get; set; }

        public string Seconds { get; set; }

        public int? HallId { get; set; }

        public Halls Halls { get; set; }

        public List<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public List<WorkoutsExercises> WorkoutsExercises { get; set; }
    }
}
