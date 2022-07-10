using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsUsersComponent
    {
        [Parameter] public User User { get; set; }

        [Parameter] public int EventId { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        public string GenderImage { get; set; }

        public EventTimeUser EventTimeUser { get; set; }

        public string Time { get; set; }

        protected override void OnInitialized()
        {
            EventTimeUser = EventsService.GetEventTimeUser(EventId, User.Id);

            if (EventTimeUser is not null)
            {
                Time = EventTimeUser.Time.ToString("g");
            }

            if (User.GenderId is not null)
            {
                GenderImage = UserService.GetGender(User.GenderId).Image;
            }
        }
    }
}
