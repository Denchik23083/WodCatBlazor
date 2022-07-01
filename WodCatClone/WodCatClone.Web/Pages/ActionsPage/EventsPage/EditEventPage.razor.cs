﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EditEventPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Parameter] public int EventId { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            IsLoginUser = UserService.IsLoginUser();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void BackToEventsList() => NavigationManager.NavigateTo("/events");
    }
}
