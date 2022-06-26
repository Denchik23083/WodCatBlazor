using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsComponent
    {
        [Parameter] public Events Event { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        public Dictionary<int, string> Month = new()
        {
            { 1, "Jan" },
            { 2, "Feb" },
            { 3, "Mar" },
            { 4, "Apr" },
            { 5, "May" },
            { 6, "Jun" },
            { 7, "Jul" },
            { 8, "Aug" },
            { 9, "Sep" },
            { 10, "Oct" },
            { 11, "Nov" },
            { 12, "Dec" }
        };

        protected override void OnInitialized()
        {
            Url = $"events/{Event.Id}";
            Image = EventsService.GetImage(Event.EventsEmblemId);
            DayStartName = Event.StartDate.Day;
            DayEndName = Event.EndDate.Day;
            MonthStartName = GetMonth(Event.StartDate.Month);
            MonthEndName = GetMonth(Event.EndDate.Month);
        }

        public string Url { get; set; }

        public string Image { get; set; }

        public string MonthStartName { get; set; }

        public string MonthEndName { get; set; }

        public int DayStartName { get; set; }

        public int DayEndName { get; set; }

        private string GetMonth(int month)
        {
            return Month.GetValueOrDefault(month);
        }
    }
}
