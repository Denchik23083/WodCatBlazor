using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class IndividualProfileHallProgramComponent
    {
        [Parameter] public Halls Hall { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string HallImage { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
            if (Hall is not null)
            {
                HallImage = HallsService.GetImage(Hall.EmblemHallId);
            }
        }

        protected override void OnParametersSet()
        {
            User = UserService.GetUser();
            if (Hall is not null)
            {
                HallImage = HallsService.GetImage(Hall.EmblemHallId);
            }
        }

        public void EditUserHall(int id)
        {
            var result = UserService.EditUserHall(User, id);

            if (result)
            {
                NavigationManager.NavigateTo($"/profile/{User.NickName}/edit", true);
            }
        }
    }
}
