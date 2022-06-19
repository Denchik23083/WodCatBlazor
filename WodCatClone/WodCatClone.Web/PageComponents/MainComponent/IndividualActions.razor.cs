using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.MainComponent
{
    public partial class IndividualActions
    {
        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        [Parameter] public Programs Program { get; set; }

        [Parameter] public Workouts Workout { get; set; }

        [Parameter] public Exercises Exercise { get; set; }

        [Parameter] public Halls Hall { get; set; }

        [Parameter] public Articles Article { get; set; }

        public string ProgramImage { get; set; }

        public string WorkoutImage { get; set; }
        
        public string ExerciseImage { get; set; }
        
        public string HallImage { get; set; }

        public string ArticleImage { get; set; }

        protected override void OnInitialized()
        {
            if (Program is not null && Program.HallId is not null)
            {
                var hall = HallsService.GetHall(Program.HallId);
                ProgramImage = HallsService.GetImage(hall.EmblemHallId);
            }
            if (Workout is not null && Workout.HallId is not null)
            {
                var hall = HallsService.GetHall(Workout.HallId);
                WorkoutImage = HallsService.GetImage(hall.EmblemHallId);
            }
            if (Exercise is not null)
            {
                ExerciseImage = ExercisesService.GetExercise(Exercise.Id).Image;
            }
            if (Hall is not null)
            {
                HallImage = HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Article is not null)
            {
                ArticleImage = ArticlesService.GetImage(Article.ArticlesEmblemId);
            }
        }
    }
}
