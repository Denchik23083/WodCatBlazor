using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class BeginEventTaskComponent
    {
        [Parameter] public Events? Event { get; set; } = new();

        [Parameter] public User? User { get; set; } = new();

        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();

        public string? Image { get; set; }

        public Workouts? Workout { get; set; } = new();
        
        public DateTime Time { get; set; }

        public EventTimeUser? EventTimeUser { get; set; } = new();

        public EventTimeUser? AddEventTimeUser = new();

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            Image = Event!.EventEmblem!.Image!;
            Workout = Event!.Workouts!;
            WorkoutsExercises = Event.Workouts!.WorkoutsExercises!;
            EventTimeUser = Event.EventTimeUsers!.FirstOrDefault(_ => _.UserId == User!.Id)!;
        }

        public async Task SubmitTime()
        {
            AddEventTimeUser!.Time = new TimeSpan(Time.Hour, Time.Minute, Time.Second);
            AddEventTimeUser!.UserId = User!.Id;
            AddEventTimeUser!.EventsId = Event!.Id;

            var result = await EventsService.AddEventTimeUserAsync(AddEventTimeUser);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}", true);
            }
        }
    }
}
