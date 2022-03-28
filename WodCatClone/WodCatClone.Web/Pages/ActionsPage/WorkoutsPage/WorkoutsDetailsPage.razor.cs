using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsDetailsPage
    {
        [Parameter] public int WorkoutId { get; set; }

        [Inject] public IWorkoutsService _workoutsService { get; set; }

        [Inject] public IUserService _userService { get; set; }

        [Inject] public IResultWorkoutsService _service { get; set; }

        [Inject] public NavigationManager _manager { get; set; }

        public Workouts Workout { get; set; }

        public string[] WorkoutExercises { get; set; }

        public bool IsLogin { get; set; }

        public EditDeleteResult EditDeleteResult { get; set; }

        public GetAllResultWorkouts GetAllResultWorkouts { get; set; }

        protected override void OnInitialized()
        {
            IsLogin = _userService.IsLoginUser();
            Workout = _workoutsService.GetWorkout(WorkoutId);
            WorkoutExercises = Workout.Exercises.Split(",");
        }

        public void Login() { _manager.NavigateTo("/login"); }

        public void IsDisplayDialog() { EditDeleteResult.Show(); }

        public void OnCancel() { EditDeleteResult.Hide(); }

        public void OnCancelEdit() { EditDeleteResult.EditHide(); }

        public void OnDelete()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            var result = _service.DeleteResultWorkouts(id);

            if (result)
            {
                EditDeleteResult.Hide();
                
                _manager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }

        public void OnEdit()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            EditDeleteResult.FillData();
            var resultWorkout = EditDeleteResult._editResultWorkout;

            var result = _service.EditResultWorkouts(resultWorkout, id);

            if (result)
            {
                _manager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }
    }
}
