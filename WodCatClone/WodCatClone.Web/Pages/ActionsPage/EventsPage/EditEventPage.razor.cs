﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EditEventPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Parameter] public int EventId { get; set; }

        public bool IsLoginUser { get; set; }

        public Events Event { get; set; }

        public User User { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Event = EventsService.GetEvent(EventId);
            if (Event is null)
            {
                NavigationManager.NavigateTo("/events");
            }
            else
            {
                IsLoginUser = UserService.IsLoginUser();
                User = UserService.GetUser();

                if (!IsLoginUser)
                {
                    NavigationManager.NavigateTo("/login");
                }

                if (User.Id != Event.UserId)
                {
                    NavigationManager.NavigateTo("/events");
                }
            }
        }

        public void BackToEventsList() => NavigationManager.NavigateTo("/events");
    }
}
