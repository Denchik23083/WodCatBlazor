using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class AddHallPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            IsLoginUser = UserService.IsLoginUser();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void BackToGymList() => NavigationManager.NavigateTo("/gymboxs");
    }
}
