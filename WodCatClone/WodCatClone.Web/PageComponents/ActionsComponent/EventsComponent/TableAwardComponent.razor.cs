using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class TableAwardComponent
    {
        [Parameter] public EventTimeUser? EventTimeUser { get; set; } = new();
        
        [Parameter] public int Place { get; set; }

        [Parameter] public int Points { get; set; }

        public string? GenderImage { get; set; }

        public string? Time { get; set; }

        public User? User { get; set; } = new();

        protected override void OnInitialized()
        {
            User = EventTimeUser!.User;

            Time = EventTimeUser.Time.ToString("g");

            GenderImage = User!.Gender!.Image!;
        }
    }
}
