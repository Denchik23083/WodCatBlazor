using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsPage
    {
        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Events> Events { get; set; } = new List<Events>();

        public bool IsLoginUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();

            await RemoveAllEndEvents();

            Events = await EventsService.GetAllEvents();
        }

        private async Task RemoveAllEndEvents()
        {
            var endEvents = await EventsService.GetAllEndEvents();

            foreach (var endEvent in endEvents)
            {
                await EventsService.AutoRemoveEvent(endEvent);
            }
        }

        public void Add() => NavigationManager.NavigateTo("/events/add");
    }
}
