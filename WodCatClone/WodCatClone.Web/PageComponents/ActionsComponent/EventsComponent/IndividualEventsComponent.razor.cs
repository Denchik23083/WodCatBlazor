using System;
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

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Url { get; set; }

        public string Image { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            if (Event.EndDate < DateTime.Now)
            {
                var result = EventsService.AutoRemoveEvent(Event.Id);

                if (result)
                {
                    NavigationManager.NavigateTo("/events", true);
                }
            }

            Url = $"events/{Event.Id}";
            Image = EventsService.GetImage(Event.EventsEmblemId);
            StartDate = Event.StartDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
            EndDate = Event.EndDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
        }
    }
}
