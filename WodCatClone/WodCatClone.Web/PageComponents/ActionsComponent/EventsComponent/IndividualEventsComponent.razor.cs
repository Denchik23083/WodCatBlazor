using System.Globalization;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsComponent
    {
        [Parameter] public Events Event { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        protected override void OnInitialized()
        {
            Url = $"events/{Event.Id}";
            Image = EventsService.GetImage(Event.EventsEmblemId);
            EndDate = Event.StartDate.ToString("dd MMMM");
            StartDate = Event.EndDate.ToString("dd MMMM");
        }

        protected override void OnParametersSet()
        {
            Url = $"events/{Event.Id}";
            Image = EventsService.GetImage(Event.EventsEmblemId);
            EndDate = Event.StartDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
            StartDate = Event.EndDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
        }

        public string Url { get; set; }

        public string Image { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
