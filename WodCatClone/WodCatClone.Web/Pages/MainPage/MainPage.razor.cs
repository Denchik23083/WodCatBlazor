using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.MainPage
{
    public partial class MainPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();

        public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        public IEnumerable<Exercises> Exercises { get; set; } = new List<Exercises>();

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public IEnumerable<Articles> Articles { get; set; } = new List<Articles>();

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUser();

            Programs = await ProgramsService.GetAllPrograms();
            Workouts = await WorkoutsService.GetAllWorkouts();
            Exercises = await ExercisesService.GetAllExercises();
            Halls = await HallsService.GetAllHalls();
            Articles = await ArticlesService.GetAllArticles();
        }
    }
}
