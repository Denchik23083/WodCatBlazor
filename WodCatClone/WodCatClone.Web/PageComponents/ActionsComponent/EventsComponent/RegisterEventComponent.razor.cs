﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class RegisterEventComponent
    {
        [Parameter] public Events Event { get; set; }

        [Parameter] public int EventId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IEventsService EventsService { get; set; }
        
        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public string RegisterDate { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string RegisterTime { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Image { get; set; }

        public string HallEmblem { get; set; }

        public bool IsLoginUser { get; set; }

        public Halls Hall { get; set; }

        public User User { get; set; }

        public ConfirmRemoveEvent ConfirmRemoveEvent { get; set; }

        protected override void OnInitialized()
        {
            StartDate = Event.StartDate.ToString("dd MMMM yyyy");
            EndDate = Event.EndDate.ToString("dd MMMM yyyy");
            RegisterDate = Event.RegisterDate.ToString("dd MMMM yyyy");
            StartTime = Event.StartDate.ToString("t");
            EndTime = Event.EndDate.ToString("t");
            RegisterTime = Event.RegisterDate.ToString("t");
            Image = EventsService.GetImage(Event.EventsEmblemId);
            Hall = HallsService.GetHall(Event.HallId);
            HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();
        }

        protected override void OnParametersSet()
        {
            StartDate = Event.StartDate.ToString("dd MMMM yyyy");
            EndDate = Event.EndDate.ToString("dd MMMM yyyy");
            RegisterDate = Event.RegisterDate.ToString("dd MMMM yyyy");
            StartTime = Event.StartDate.ToString("t");
            EndTime = Event.EndDate.ToString("t");
            RegisterTime = Event.RegisterDate.ToString("t");
            Image = EventsService.GetImage(Event.EventsEmblemId);
            Hall = HallsService.GetHall(Event.HallId);
            HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Edit() => NavigationManager.NavigateTo($"/events/{EventId}/edit");

        public void OnShow() => ConfirmRemoveEvent.Show();

        public void OnCancel() => ConfirmRemoveEvent.Hide();

        public void Join()
        {
            var result = EventsService.JoinEvent(Event.Id, User);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}", true);
            }
        }

        public void Exit()
        {
            var result = EventsService.ExitEvent(Event.Id, User);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{EventId}", true);
            }
        }
    }
}