using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class LogoutPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IAuthService AuthService { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            var result = await AuthService.LogoutAsync();

            if (result)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
