using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.Pages.MainPage
{
    public partial class MainPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        public IEnumerable<Programs> Programs { get; set; }

        public IEnumerable<Workouts> Workouts { get; set; }

        public IEnumerable<Exercises> Exercises { get; set; }

        public IEnumerable<Halls> Halls { get; set; }

        public IEnumerable<Articles> Articles { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Programs = await ProgramsService.GetAllPrograms();
            Workouts = await WorkoutsService.GetAllWorkouts();
            Exercises = await ExercisesService.GetAllExercises();
            Halls = await HallsService.GetAllHalls();
            Articles = await ArticlesService.GetAllArticles();
        }
    }
}
