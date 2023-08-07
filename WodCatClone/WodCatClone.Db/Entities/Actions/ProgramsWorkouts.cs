namespace WodCatClone.Db.Entities.Actions
{
    public class ProgramsWorkouts
    {
        public int Id { get; set; }

        public int ProgramsId { get; set; }

        public Programs? Programs { get; set; }

        public int WorkoutsId { get; set; }

        public Workouts? Workouts { get; set; }
    }
}
