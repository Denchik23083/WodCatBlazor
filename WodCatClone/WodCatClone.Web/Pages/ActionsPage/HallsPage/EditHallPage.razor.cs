using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class EditHallPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        public bool IsLoginUser { get; set; }

        public Halls Hall { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            Hall = HallsService.GetHall(HallId);
            IsLoginUser = UserService.IsLoginUser();
            User = UserService.GetUser();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }

            if (User.Id != Hall.UserId)
            {
                NavigationManager.NavigateTo("/gymboxs");
            }
        }

        public void BackToGymList() => NavigationManager.NavigateTo($"/gymboxs/{HallId}");
    }
}
