using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsUsersComponent
    {
        [Parameter] public User? User { get; set; } = new();

        public string? GenderImage { get; set; }

        protected override void OnInitialized()
        {
            GenderImage = User!.Gender!.Image!;
        }
    }
}
