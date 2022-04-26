using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService Service { get; set; }

        [Inject] private NavigationManager Manager { get; set; }

        private Register _mainRegister = new();

        private bool IsRegister { get; set; }

        public bool IsNext { get; set; }

        public void Register()
        {
            IsRegister = Service.Register(_mainRegister);
            if (IsRegister)
            {
                Manager.NavigateTo("/login");
            }
        }

        public void MainRegister()
        {
            if (_mainRegister.Password == _mainRegister.ConfirmPassword)
            {
                IsNext = true;
            }
        }
    }
}
