using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class ConfirmRemoveEvent
    {
        [Parameter] public EventCallback OnShow { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public int EventId { get; set; }

        [Parameter] public Events Event { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public bool DisplayRemoveEvent { get; set; }

        public void Show() => DisplayRemoveEvent = true;

        public void Hide() => DisplayRemoveEvent = false;

        public void Remove()
        {
            var result = EventsService.RemoveEvent(EventId);

            NavigationManager.NavigateTo(result ? "/events" : $"/events/{EventId}");
        }
    }
}
