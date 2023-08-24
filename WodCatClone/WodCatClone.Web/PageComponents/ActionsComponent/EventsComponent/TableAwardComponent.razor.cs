using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class TableAwardComponent
    {
        [Parameter] public EventTimeUser EventTimeUser { get; set; }
        
        [Parameter] public int Place { get; set; }

        [Parameter] public int EventId { get; set; }

        [Parameter] public int Points { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public string GenderImage { get; set; }

        public string Time { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser(EventTimeUser.UserId);

            Time = EventTimeUser.Time.ToString("g");
            
            GenderImage = UserService.GetGender(User.GenderId).Image;
        }
    }
}
