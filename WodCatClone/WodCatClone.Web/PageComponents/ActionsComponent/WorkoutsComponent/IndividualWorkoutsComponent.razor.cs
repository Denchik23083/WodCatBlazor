using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workout { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }
        
        public string[] WorkoutsCategory { get; set; }

        public string Image { get; set; }

        public Halls Hall { get; set; }

        public string Url = string.Empty;

        public int Value { get; set; }

        public int ResultWorkoutsCount { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Value = 0;
            Hall = await HallsService.GetHall(Workout.HallId);
            if (Hall is not null)
            {
                Image = await HallsService.GetImage(Hall.EmblemHallId).ConfigureAwait(false);
            }
            WorkoutsCategory = Workout.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetAllResultWorkouts(Workout.Id).Count();
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workout.Id);
        }

        protected override async Task OnParametersSetAsync()
        {
            Value = 0;
            Hall = await HallsService.GetHall(Workout.HallId);
            Image = await HallsService.GetImage(Hall.EmblemHallId);
            WorkoutsCategory = Workout.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetAllResultWorkouts(Workout.Id).Count();
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workout.Id);
        }

        public void Id()
        {
            Url = $"workouts/{Workout.Id}";
            NavigationManager.NavigateTo(Url);
        }
    }
}
