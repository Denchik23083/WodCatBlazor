using System;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Db.Entities.Actions
{
    public class ResultWorkouts
    {
        public int Id { get; set; }

        public string Minutes { get; set; }

        public string Seconds { get; set; }

        public string Comment { get; set; }

        public int Repeat { get; set; }

        public int Fascination { get; set; }

        public int Load { get; set; }

        public DateTime PublishDate { get; set; }

        public int WorkoutId { get; set; }

        public Workouts Workouts { get; set; }

        public int? UserId { get; set; }

        public User User { get; set; }
    }
}
