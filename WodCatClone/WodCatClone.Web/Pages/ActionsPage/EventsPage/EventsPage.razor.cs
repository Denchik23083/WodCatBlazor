using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsPage
    {
        [Inject] public IEventsService EventsService { get; set; }

        public IEnumerable<Events> Events { get; set; }

        protected override void OnInitialized()
        {
            Events = EventsService.GetAllEvents();
        }
    }
}
