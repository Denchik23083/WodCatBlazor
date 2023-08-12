using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;

namespace WodCatClone.Web.Pages.MainPage
{
    public partial class MainPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();

        public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        public IEnumerable<Exercises> Exercises { get; set; } = new List<Exercises>();

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public IEnumerable<Articles> Articles { get; set; } = new List<Articles>();

        protected override async Task OnInitializedAsync()
        {
            Programs = ProgramsService.GetAllPrograms();
            Workouts = WorkoutsService.GetAllWorkouts();
            Exercises = await ExercisesService.GetAllExercises();
            Halls = HallsService.GetAllHalls();
            Articles = ArticlesService.GetAllArticles();
        }
    }
}
