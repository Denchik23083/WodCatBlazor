using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workouts { get; set; }

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
            Value = 0;
            Hall = HallsService.GetHall(Workouts.HallId);
            if (Hall is not null)
            {
                Image = HallsService.GetImage(Hall.EmblemHallId);
            }
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetCountResultWorkouts(Workouts.Id);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workouts.Id);
        }

        protected override void OnParametersSet()
        {
            Value = 0;
            Hall = HallsService.GetHall(Workouts.HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetCountResultWorkouts(Workouts.Id);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workouts.Id);
        }

        public void Id()
        {
            Url = $"workouts/{Workouts.Id}";
            NavigationManager.NavigateTo(Url);
        }
    }
}
