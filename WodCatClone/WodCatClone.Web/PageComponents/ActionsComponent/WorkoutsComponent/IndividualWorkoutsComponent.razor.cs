using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workouts { get; set; }

        [Inject] public NavigationManager _manager { get; set; }

        [Inject] public IResultWorkoutsService _service { get; set; }

        [Inject] public IWorkoutsService _workoutsService { get; set; }

        public string[] WorkoutsExercises { get; set; }

        public string[] WorkoutsCategory { get; set; }

        public string Image { get; set; }

        public string _url = string.Empty;
        public int value { get; set; } = 0;

        public int ResultWorkoutsCount { get; set; }

        protected override void OnInitialized()
        {
            Image = _workoutsService.GetImage(Workouts.EmblemHallId);
            WorkoutsExercises = Workouts.Exercises.Split(",");
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = _service.GetCountResultWorkouts(Workouts.Id);
        }

        public void Id()
        {
            _url = $"workouts/{Workouts.Id}";
            _manager.NavigateTo(_url);
        }
    }
}
