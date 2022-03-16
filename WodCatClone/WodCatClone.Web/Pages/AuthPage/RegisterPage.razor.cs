using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService Service { get; set; }
        [Inject] private NavigationManager Manager { get; set; }

        private Register _register = new();

        private bool _isRegister;

        public void Register()
        {
            if (_register.Password == _register.ConfirmPassword)
            {
                _isRegister = Service.Register(_register);
                if (_isRegister)
                {
                    Manager.NavigateTo("/login");
                }
            }
        }
    }
}
