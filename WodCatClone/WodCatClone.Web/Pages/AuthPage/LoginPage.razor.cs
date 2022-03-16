using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class LoginPage
    {
        [Inject] private IAuthService Service { get; set; }

        [Inject] private NavigationManager Manager { get; set; }

        private Login _login = new();

        private bool _isLogin;

        public void Login()
        {
            _isLogin = Service.Login(_login);
            if (_isLogin)
            {
                Manager.NavigateTo("/");
            }
        }
    }
}
