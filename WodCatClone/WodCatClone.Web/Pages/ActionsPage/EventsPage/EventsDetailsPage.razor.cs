using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public Events Event { get; set; }

        public User User { get; set; }

        public string Image { get; set; }

        protected override void OnInitialized()
        {
            Event = EventsService.GetEvent(EventId);
            Image = EventsService.GetImage(Event.EventsEmblemId);
            User = UserService.GetUser();
        }
    }
}
