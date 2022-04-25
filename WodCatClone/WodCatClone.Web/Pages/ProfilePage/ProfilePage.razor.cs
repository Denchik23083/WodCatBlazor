using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class ProfilePage
    {
        [Parameter] public string NickName { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public User User { get; set; }

        public User UserEnter { get; set; }

        public bool IsLoginUser { get; set; }

        public bool IsEnterUser { get; set; }

        public string Image { get; set; }

        public Halls Hall { get; set; }

        public string HallEmblem { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser(NickName);
            UserEnter = UserService.GetUser();

            IsLoginUser = UserService.IsLoginUser();

            Image = UserService.GetGender(User.GenderId);

            if (User.HallId is not null)
            {
                Hall = HallsService.GetHall(User.HallId);
                HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            }

            if (UserEnter is not null)
            {
                if (User.NickName == UserEnter.NickName)
                {
                    IsEnterUser = true;
                }
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/profile/{NickName}/edit");
    }
}
