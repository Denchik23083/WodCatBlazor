using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsUsersComponent
    {
        [Parameter] public User? User { get; set; } = new();

        public string? GenderImage { get; set; }

        public string? Time { get; set; }

        protected override void OnInitialized()
        {
            var eventTimeUser = User!.EventTimeUsers!.FirstOrDefault(_ => _.EventsId == User.EventId);

            if (eventTimeUser is not null)
            {
                Time = eventTimeUser.Time.ToString("g");
            }

            GenderImage = User!.Gender!.Image!;
        }
    }
}
