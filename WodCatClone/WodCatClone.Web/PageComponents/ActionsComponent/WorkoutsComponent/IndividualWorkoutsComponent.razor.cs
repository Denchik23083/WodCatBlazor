using System.Collections.Generic;
using System.Linq;
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

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            Value = 0;
            Hall = HallsService.GetHall(Workout.HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
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
