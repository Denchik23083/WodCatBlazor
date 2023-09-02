using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class RegisterEventComponent
    {
        [Parameter] public Events? Event { get; set; } = new();

        [Parameter] public User? User { get; set; } = new();

        [Parameter] public int EventId { get; set; }

        [Parameter] public bool IsLoginUser { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IEventsService EventsService { get; set; } = null!;

        public string? RegisterDate { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public string? Image { get; set; }

        public string? HallEmblem { get; set; }

        public Halls? Hall { get; set; } = new();

        public ConfirmRemoveEvent? ConfirmRemoveEvent { get; set; } = new();

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

        public void Edit() => NavigationManager.NavigateTo($"/events/{EventId}/edit");

        public void OnShow() => ConfirmRemoveEvent!.Show();

        public void OnCancel() => ConfirmRemoveEvent!.Hide();

        public async Task Join()
        {
            var result = await EventsService.JoinEvent(Event!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}", true);
            }
        }

        public async Task Exit()
        {
            var result = await EventsService.ExitEvent(Event!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}", true);
            }
        }
    }
}
