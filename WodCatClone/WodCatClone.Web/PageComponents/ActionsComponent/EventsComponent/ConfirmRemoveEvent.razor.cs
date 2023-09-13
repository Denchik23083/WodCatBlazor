using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class ConfirmRemoveEvent
    {
        [Parameter] public EventCallback OnShow { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public int EventId { get; set; }

        [Parameter] public Events? Event { get; set; } = new();

        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public bool DisplayRemoveEvent { get; set; }

        public void Show() => DisplayRemoveEvent = true;

        public void Hide() => DisplayRemoveEvent = false;

        public async Task Remove()
        {
            var result = await EventsService.RemoveEventAsync(EventId);

            NavigationManager.NavigateTo(result ? "/events" : $"/events/{EventId}");
        }
    }
}
