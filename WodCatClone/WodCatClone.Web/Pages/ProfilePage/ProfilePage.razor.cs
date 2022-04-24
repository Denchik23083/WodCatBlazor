using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class ProfilePage
    {
        [Parameter] public string NickName { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public User User { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }
    }
}
