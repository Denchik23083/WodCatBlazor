using AutoMapper;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Web.Models;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class LoginPage
    {
        [Inject] public IAuthService AuthService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        public LoginModel LoginModel = new();

        public bool IsFallLogin { get; set; }

        public async Task Login()
        {
            var mappedUser = Mapper.Map<User>(LoginModel);

            var result = await AuthService.Login(mappedUser);

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
