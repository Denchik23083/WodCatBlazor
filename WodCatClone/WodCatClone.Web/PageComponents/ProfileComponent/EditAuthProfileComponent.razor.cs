using AutoMapper;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Models;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditAuthProfileComponent
    {
        [Parameter] public User? User { get; set; } = new();

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IAuthService AuthService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        public string? Image { get; set; }

        public RegisterModel? UpdateAuth { get; set; } = new();

        protected override void OnInitialized()
        {
            UpdateAuth = Mapper.Map<RegisterModel>(User);

            if (UpdateAuth?.Gender is not null)
            {
                Image = UpdateAuth.Gender!.Image!;
            }
        }

        public async Task Auth()
        {
            if (UpdateAuth?.Password == UpdateAuth?.ConfirmPassword)
            {
                var mappedAuth = Mapper.Map<User>(UpdateAuth);

                var result = await UserService.UpdateAuth(mappedAuth, User!.Id);

                if (result)
                {
                    var logout = AuthService.Logout();

                    if (logout)
                    {
                        NavigationManager.NavigateTo("/");
                    }
                }
            }
        }
    }
}
