using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class IndividualHallsUsersComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public string Image { get; set; }

        public string GenderImage { get; set; }

        protected override void OnInitialized()
        {
            if (User.GenderId is not null)
            {
                GenderImage = UserService.GetGender(User.GenderId).Image;
            }
        }
    }
}
