using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; } = null!;

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

        public string? RegisterDate { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public string? Image { get; set; }

        public string? HallEmblem { get; set; }

        public Halls? Hall { get; set; } = new();

        public ConfirmRemoveEvent? ConfirmRemoveEvent { get; set; } = new();

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

                StartDate = Event!.StartDate.ToString("dd MMMM yyyy HH:mm:ss");
                EndDate = Event!.EndDate.ToString("dd MMMM yyyy HH:mm:ss");
                RegisterDate = Event!.RegisterDate.ToString("dd MMMM yyyy HH:mm:ss");

                if (Event!.EventEmblem is not null)
                {
                    Image = Event!.EventEmblem!.Image!;
                }

                if (Event!.Halls is not null)
                {
                    Hall = Event!.Halls!;
                    if (Hall.EmblemHall is not null)
                    {
                        HallEmblem = Hall.EmblemHall!.Image!;
                    }
                }
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/events/{EventId}/edit");

        public void OnShow() => ConfirmRemoveEvent!.Show();

        public void OnCancel() => ConfirmRemoveEvent!.Hide();

        public async Task Join()
        {
            var result = await EventsService.JoinEvent(Event!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}");
            }
        }

        public async Task Exit()
        {
            var result = await EventsService.ExitEvent(Event!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}");
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
