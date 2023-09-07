using AutoMapper;
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

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        public Workouts? Workout { get; set; } = new();

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();

        public IEnumerable<ResultWorkouts> ResultWorkouts { get; set; } = new List<ResultWorkouts>();

        public string? Image { get; set; }

        public bool IsLoginUser { get; set; }

        public User? User { get; set; } = new();

        public Halls? Hall { get; set; } = new();

        public EditDeleteResult EditDeleteResult { get; set; } = new();

        public GetAllResultWorkouts GetAllResultWorkouts { get; set; } = new();

        public StartWorkout StartWorkout { get; set; } = new();

        public int ResultWorkoutId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUser();

            Workout = await WorkoutsService.GetWorkout(WorkoutId);

            if (Workout is null)
            {
                NavigationManager.NavigateTo("/workouts");
            }
            else
            {
                IsLoginUser = await UserService.IsLoginUser();

                Hall = Workout.Halls!;
                if (Hall is not null)
                {
                    Image = Hall.EmblemHall!.Image;
                }

                WorkoutsExercises = Workout.WorkoutsExercises!;
                ResultWorkouts = Workout.ResultWorkouts!;
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

        public async Task OnEdit()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            EditDeleteResult.FillData();

            var resultWorkout = EditDeleteResult.EditResultWorkout;

            var mappedResultWorkouts = Mapper.Map<ResultWorkouts>(resultWorkout);

            var result = await WorkoutsService.EditResultWorkouts(mappedResultWorkouts, id);

            if (result)
            {
                NavigationManager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }

        public async Task OnDelete()
        {
            var id = GetAllResultWorkouts.ResultWorkoutId;

            var result = await WorkoutsService.DeleteResultWorkouts(id);

            if (result)
            {
                EditDeleteResult.Hide();
                
                NavigationManager.NavigateTo($"/workouts/{WorkoutId}", true);
            }
        }
    }
}
