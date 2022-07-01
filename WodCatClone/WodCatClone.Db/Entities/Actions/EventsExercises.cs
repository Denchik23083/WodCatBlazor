namespace WodCatClone.Db.Entities.Actions
{
    public class EventsExercises
    {
        public int Id { get; set; }

        public int EventsId { get; set; }

        public Events Events { get; set; }

        public int ExercisesId { get; set; }

        public Exercises Exercises { get; set; }
    }
}
