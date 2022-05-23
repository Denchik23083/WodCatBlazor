using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class IndividualProfileHallComponent
    {
        [Parameter] public Halls Hall { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Image { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
            Image = HallsService.GetImage(Hall.EmblemHallId);
        }

        protected override void OnParametersSet()
        {
            User = UserService.GetUser();
            Image = HallsService.GetImage(Hall.EmblemHallId);
        }

        public void EditUserHall(int id)
        {
            var result = UserService.EditUserHall(User, id);

            NavigationManager.NavigateTo(result ? $"/profile/{User.NickName}" : $"/profile/{User.NickName}/edit");
        }
    }
}
