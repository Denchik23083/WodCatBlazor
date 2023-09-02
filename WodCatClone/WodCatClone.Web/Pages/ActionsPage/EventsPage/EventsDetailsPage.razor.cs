using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public Events? Event { get; set; } = new();

        public Workouts? Workout { get; set; } = new();

        public IEnumerable<User> Users { get; set; } = new List<User>();

        public IEnumerable<EventTimeUser> EventTimeUsers { get; set; } = new List<EventTimeUser>();

        public bool DisplayEvent { get; set; } = true;

        public bool DisplayEventWorkoutExercise { get; set; }

        public bool DisplayUser { get; set; }

        public bool DisplayAward { get; set; }

        public bool IsLoginUser { get; set; }

        public User? User { get; set; } = new();
        
        protected override async Task OnInitializedAsync()
        {
            await FillOverrideFunctions();
        }

        protected override async Task OnParametersSetAsync()
        {
            await FillOverrideFunctions();
        }

        private async Task FillOverrideFunctions()
        {
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();

            Event = await EventsService.GetEvent(EventId);
            if (Event is null || Event.EndDate < DateTime.Now)
            {
                NavigationManager.NavigateTo("/events", true);
            }
            else
            {
                Users = Event.Users!;
                Workout = Event.Workouts!;
                EventTimeUsers = Event.EventTimeUsers!
                    .OrderByDescending(b => b.Time)
                    .Take(3)
                    .Reverse();
            }
        }

        public void DisplayEvents()
        {
            DisplayEvent = true;
            DisplayUser = false;
            DisplayEventWorkoutExercise = false;
            DisplayAward = false;
        }

        public void DisplayUsers()
        {
            DisplayEvent = false;
            DisplayUser = true;
            DisplayEventWorkoutExercise = false;
            DisplayAward = false;
        }

        public void DisplayEventsWorkoutsExercises()
        {
            DisplayEvent = false;
            DisplayUser = false;
            DisplayEventWorkoutExercise = true;
            DisplayAward = false;
        }

        public void DisplayAwards()
        {
            DisplayEvent = false;
            DisplayUser = false;
            DisplayEventWorkoutExercise = false;
            DisplayAward = true;
        }
    }
}
