using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService Service { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] private NavigationManager Manager { get; set; }

        private Register _mainRegister = new();

        private bool IsRegister { get; set; }

        public bool IsNext { get; set; }

        public bool Man { get; set; } = false;

        public bool Woman { get; set; } = false;

        public string Gender { get; set; }

        public void Register()
        {
            if (Man)
            {
                Gender = "Мужской";
            }
            if (Woman)
            {
                Gender = "Женский";
            }

            var gender = UserService.GetGender(Gender);
            _mainRegister.GenderId = gender.Id;

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
