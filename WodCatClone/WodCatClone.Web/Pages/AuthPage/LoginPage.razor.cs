using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class LoginPage
    {
        [Inject] private IAuthService AuthService { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        public Login MainLogin = new();

        public bool IsFallLogin { get; set; }

        public async Task Login()
        {
            var result = await AuthService.Login(MainLogin);
            if (result)
            {
                IsFallLogin = false;
                NavigationManager.NavigateTo("/");
            }
            else
            {
                IsFallLogin = true;
            }
        }
    }
}
