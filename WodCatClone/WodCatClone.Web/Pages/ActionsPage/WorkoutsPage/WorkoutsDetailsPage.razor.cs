using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsDetailsPage
    {
        [Parameter] public int WorkoutId { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Workouts Workout { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public string Image { get; set; }

        public bool IsLoginUser { get; set; }

        public Halls Hall { get; set; }

        public EditDeleteResult EditDeleteResult { get; set; }

        public GetAllResultWorkouts GetAllResultWorkouts { get; set; }

        public StartWorkout StartWorkout { get; set; }

        public int ResultWorkoutId { get; set; } = 0;

        protected override void OnInitialized()
        {
            Workout = WorkoutsService.GetWorkout(WorkoutId);
            if (Workout is null)
            {
                NavigationManager.NavigateTo("/workouts");
            }
            else
            {
                IsLoginUser = UserService.IsLoginUser();
                Hall = HallsService.GetHall(Workout.HallId);
                if (Hall is not null)
                {
                    Image = HallsService.GetImage(Hall.EmblemHallId);
                }
                WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(WorkoutId);
            }
        }

        public void Login() => NavigationManager.NavigateTo("/login");

        public void IsDisplayDialog()
        {
            ResultWorkoutId = GetAllResultWorkouts.ResultWorkoutId;
            EditDeleteResult.Show();
        }

        public void OnCancel() => EditDeleteResult.Hide(); 

        public void OnCancelEdit() => EditDeleteResult.EditHide(); 

        public void OnCancelEditStart() => StartWorkout.Hide(); 

        public void Start() => StartWorkout.Show();

        public void OnDelete()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            var result = ResultWorkoutsService.DeleteResultWorkouts(id);

            if (result)
            {
                EditDeleteResult.Hide();
                
                NavigationManager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }

        public async Task OnEdit()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            EditDeleteResult.FillData();
            var resultWorkout = EditDeleteResult.EditResultWorkout;

            var result = await ResultWorkoutsService.EditResultWorkouts(resultWorkout, id);

            if (result)
            {
                NavigationManager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }
    }
}
