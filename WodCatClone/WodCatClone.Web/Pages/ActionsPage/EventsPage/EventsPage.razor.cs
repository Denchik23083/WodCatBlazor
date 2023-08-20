using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsPage
    {
        [Inject] public IEventsService EventsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public IEnumerable<Events> Events { get; set; } = new List<Events>();

        public bool IsLoginUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Events = await EventsService.GetAllEvents();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Add() => NavigationManager.NavigateTo("/events/add");
    }
}
