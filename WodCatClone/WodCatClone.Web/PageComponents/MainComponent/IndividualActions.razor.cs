using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;

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

        protected override async Task OnInitializedAsync()
        {
            if (Program is not null && Program.ProgramsEmblemId is not null)
            {
                ProgramImage = await ProgramsService.GetImage(Program.ProgramsEmblemId);
            }
            if (Workout is not null && Workout.HallId is not null)
            {
                var hall = await HallsService.GetHall(Workout.HallId);
                WorkoutImage = await HallsService.GetImage(hall.EmblemHallId);
            }
            if (Exercise is not null)
            {
                var exercise = await ExercisesService.GetExercise(Exercise.Id);
                ExerciseImage = exercise.Image;
            }
            if (Hall is not null)
            {
                HallImage = await HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Article is not null && Article.ArticleEmblemId is not null)
            {
                ArticleImage = await ArticlesService.GetImage(Article.ArticleEmblemId);
            }
        }
    }
}
