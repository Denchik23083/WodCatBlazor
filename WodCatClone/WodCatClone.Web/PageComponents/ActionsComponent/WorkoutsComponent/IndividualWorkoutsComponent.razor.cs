using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workouts { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public string[] WorkoutsExercises { get; set; }

        public string[] WorkoutsCategory { get; set; }

        public string Image { get; set; }

        public string _url = string.Empty;
        public int value { get; set; } = 0;

        public int ResultWorkoutsCount { get; set; }

        protected override void OnInitialized()
        {
            Image = WorkoutsService.GetImage(Workouts.EmblemHallId);
            WorkoutsExercises = Workouts.Exercises.Split(",");
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetCountResultWorkouts(Workouts.Id);
        }

        public void Id()
        {
            _url = $"workouts/{Workouts.Id}";
            NavigationManager.NavigateTo(_url);
        }
    }
}
