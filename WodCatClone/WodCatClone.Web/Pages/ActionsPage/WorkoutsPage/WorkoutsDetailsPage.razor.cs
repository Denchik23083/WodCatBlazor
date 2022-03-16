using System.Collections.Generic;
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

        public Workouts Workout { get; set; }

        public string[] WorkoutExercises { get; set; }

        public bool IsLogin { get; set; }

        public EditDeleteResult EditDeleteResult { get; set; }

        protected override void OnInitialized()
        {
            IsLogin = _userService.IsLoginUser();
            Workout = _workoutsService.GetWorkout(WorkoutId);
            WorkoutExercises = Workout.Exercises.Split(",");
        }

        public void IsDisplayDialog() { EditDeleteResult.Show(); }

        public void OnCancel() { EditDeleteResult.Hide(); }

        public void OnDelete()
        {
            //TODO: Logic Delete
            EditDeleteResult.Hide();
        }

        public void OnEdit()
        {
            //TODO: Logic Delete Edit
            EditDeleteResult.Hide();
        }
    }
}
