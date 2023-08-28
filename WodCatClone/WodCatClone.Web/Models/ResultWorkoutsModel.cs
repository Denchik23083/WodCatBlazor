namespace WodCatClone.Web.Models
{
    public class ResultWorkoutsModel
    {
        public TimeSpan Time { get; set; }

        public string? Comment { get; set; }

        public int Repeat { get; set; }

        public int Fascination { get; set; }

        public int Load { get; set; }

        public int WorkoutId { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
