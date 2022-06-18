namespace WodCatClone.Db.Entities.Actions
{
    public class WorkoutsExercises
    {
        public int Id { get; set; }

        public int CountRepeats { get; set; }

        public int WorkoutsId { get; set; }

        public Workouts Workouts { get; set; }

        public int ExercisesId { get; set; }

        public Exercises Exercises { get; set; }
    }
}
