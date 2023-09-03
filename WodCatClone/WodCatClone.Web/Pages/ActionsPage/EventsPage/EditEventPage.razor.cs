using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EditEventPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        public IEnumerable<EventEmblem> EventEmblem { get; set; } = new List<EventEmblem>();

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public IEnumerable<HallEmblem> HallEmblem { get; set; } = new List<HallEmblem>();

        public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        public bool IsLoginUser { get; set; }

        public Events? Event { get; set; } = new();

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUser();

            IsLoginUser = await UserService.IsLoginUser();

            Event = await EventsService.GetEvent(EventId);
            if (Event is null)
            {
                NavigationManager.NavigateTo("/events");
            }
            else
            {
                if (!IsLoginUser)
                {
                    NavigationManager.NavigateTo("/login");
                }

                if (User?.Id != Event.UserId)
                {
                    NavigationManager.NavigateTo("/events");
                }
            }

            EventEmblem = await EventsService.GetAllEventEmblem();
            Halls = await HallsService.GetAllHalls();
            HallEmblem = await HallsService.GetAllHallEmblem();
            Workouts = await WorkoutsService.GetAllWorkouts();
        }

        public void BackToEventsList() => NavigationManager.NavigateTo("/events");
    }
}
