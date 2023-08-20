using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.MainComponent
{
    public partial class IndividualActions
    {
        [Parameter] public Programs? Program { get; set; }

        [Parameter] public Workouts? Workout { get; set; }

        [Parameter] public Exercises? Exercise { get; set; }

        [Parameter] public Halls? Hall { get; set; }

        [Parameter] public Articles? Article { get; set; }

        public string? ProgramImage { get; set; }

        public string? WorkoutImage { get; set; }
        
        public string? ExerciseImage { get; set; }
        
        public string? HallImage { get; set; }

        public string? ArticleImage { get; set; }

        protected override void OnInitialized()
        {
            if (Program?.ProgramEmblem is not null)
            {
                ProgramImage = Program.ProgramEmblem!.Image;
            }
            if (Workout?.HallId is not null)
            {
                WorkoutImage = Workout.Halls!.EmblemHall!.Image;
            }
            if (Exercise?.Image is not null)
            {
                ExerciseImage = Exercise.Image;
            }
            if (Hall?.EmblemHall is not null)
            {
                HallImage = Hall.EmblemHall!.Image;
            }
            if (Article?.ArticleEmblem is not null)
            {
                ArticleImage = Article.ArticleEmblem!.Image;
            }
        }
    }
}
