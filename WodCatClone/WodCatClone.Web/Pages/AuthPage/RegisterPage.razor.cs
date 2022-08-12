using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService AuthService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        public Register MainRegister = new();

        public bool Man { get; set; } = true;

        public bool Woman { get; set; } = false;

        public string Gender { get; set; }

        public void Register()
        {
            if (MainRegister.Password == MainRegister.ConfirmPassword)
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
                MainRegister.GenderId = gender.Id;

                var result = AuthService.Register(MainRegister);
                if (result)
                {
                    NavigationManager.NavigateTo("/login");
                }
            }
        }
    }
}
