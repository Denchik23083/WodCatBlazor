﻿using System.Globalization;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsComponent
    {
        [Parameter] public Events Event { get; set; } = new();

        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public string? Url { get; set; }

        public string? Image { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

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
            Url = $"events/{Event.Id}";
            Image = Event.EventEmblem!.Image;
            StartDate = Event.StartDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
            EndDate = Event.EndDate.ToString("dd MMMM", CultureInfo.InvariantCulture);
        }
    }
}
