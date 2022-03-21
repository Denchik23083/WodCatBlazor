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

        public Workouts Workout { get; set; }

        public string[] WorkoutExercises { get; set; }

        public bool IsLogin { get; set; }

        public EditDeleteResult EditDeleteResult { get; set; }

        public IEnumerable<ResultWorkouts> ResultWorkouts { get; set; }

        public User user = new();

        public int EditDeleteResultId { get; set; }

        protected override void OnInitialized()
        {
            IsLogin = _userService.IsLoginUser();
            Workout = _workoutsService.GetWorkout(WorkoutId);
            WorkoutExercises = Workout.Exercises.Split(",");
            ResultWorkouts = _service.GetAllResultWorkouts(WorkoutId);
            user = _userService.GetUser();
        }

        public void IsDisplayDialog() { EditDeleteResult.Show(); }

        public void OnCancel() { EditDeleteResult.Hide(); }

        public void OnDelete()
        {
            var id = EditDeleteResultId;
            EditDeleteResult.Hide();
        }

        public void OnEdit()
        {
            //TODO: Logic Edit
            EditDeleteResult.Hide();
        }

        public void GetId(int itemId)
        {
            EditDeleteResultId = itemId;
        }
    }
}
