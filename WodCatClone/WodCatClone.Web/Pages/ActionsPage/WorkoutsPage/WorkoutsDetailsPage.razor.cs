using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
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

        public DeleteResult DeleteResult { get; set; }

        protected override void OnInitialized()
        {
            IsLogin = _userService.IsLoginUser();
            Workout = _workoutsService.GetWorkout(WorkoutId);
            WorkoutExercises = Workout.Exercises.Split(",");
        }

        public void IsDisplayDialog() { DeleteResult.Show(); }

        public void OnCancel() { DeleteResult.Hide(); }

        public void OnDelete()
        {
            var result = _service.DeleteResultWorkouts();

            if (result)
            {
                DeleteResult.Hide();
                _manager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }
    }
}
