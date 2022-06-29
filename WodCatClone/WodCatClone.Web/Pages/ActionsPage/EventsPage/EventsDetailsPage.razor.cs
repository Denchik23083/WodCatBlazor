using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public ConfirmRemoveEvent ConfirmRemoveEvent { get; set; }

        public Events Event { get; set; }

        public User User { get; set; }

        public Halls Hall { get; set; }

        public IEnumerable<User> Users { get; set; }

        public string Image { get; set; }

        public string HallEmblem { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public bool DisplayEvent { get; set; } = true;

        public bool DisplayUser { get; set; }

        public bool IsLoginUser { get; set; }

        public string Top = "notLoginTop";

        protected override void OnInitialized()
        {
            Event = EventsService.GetEvent(EventId);
            StartDate = Event.StartDate.ToString("dd MMMM yyyy");
            EndDate = Event.EndDate.ToString("dd MMMM yyyy");
            StartTime = Event.StartDate.ToString("t");
            EndTime = Event.EndDate.ToString("t");
            Image = EventsService.GetImage(Event.EventsEmblemId);
            User = UserService.GetUser();
            Users = EventsService.GetAllEventsUsers(EventId);
            IsLoginUser = UserService.IsLoginUser();
            Hall = HallsService.GetHall(Event.HallId);
            HallEmblem = HallsService.GetImage(Hall.EmblemHallId);

            if (IsLoginUser) Top = "loginTop";
        }

        protected override void OnParametersSet()
        {
            Event = EventsService.GetEvent(EventId);
            StartDate = Event.StartDate.ToString("dd MMMM yyyy");
            EndDate = Event.EndDate.ToString("dd MMMM yyyy");
            StartTime = Event.StartDate.ToString("T");
            EndTime = Event.EndDate.ToString("T");
            Image = EventsService.GetImage(Event.EventsEmblemId);
            User = UserService.GetUser();
            Users = EventsService.GetAllEventsUsers(EventId);
            IsLoginUser = UserService.IsLoginUser();
            Hall = HallsService.GetHall(Event.HallId);
            HallEmblem = HallsService.GetImage(Hall.EmblemHallId);

            if (IsLoginUser) Top = "loginTop";
        }

        public void Edit() => NavigationManager.NavigateTo($"/events/{EventId}/edit");

        public void OnShow() => ConfirmRemoveEvent.Show();

        public void OnCancel() => ConfirmRemoveEvent.Hide();

        public void DisplayEvents()
        {
            DisplayEvent = true;
            DisplayUser = false;
        }

        public void DisplayUsers()
        {
            DisplayEvent = false;
            DisplayUser = true;
        }
    }
}
