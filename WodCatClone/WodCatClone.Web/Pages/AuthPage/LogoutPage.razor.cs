using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class LogoutPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IAuthService AuthService { get; set; }

        protected override void OnInitialized()
        {
            var result = AuthService.Logout();

            if (result)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
