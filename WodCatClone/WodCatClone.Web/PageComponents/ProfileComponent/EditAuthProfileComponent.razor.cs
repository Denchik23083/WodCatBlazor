using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Models;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditAuthProfileComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IAuthService AuthService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Image { get; set; }

        public RegisterModel AuthUser { get; set; }

        protected override void OnInitialized()
        {
            AuthUser = Map(User);
            
            Image = UserService.GetGender(User.GenderId).Image;
        }

        public async Task Auth()
        {
            if (AuthUser.Password == AuthUser.ConfirmPassword)
            {
                var result = await UserService.UpdateAuth(Map(AuthUser), User.Id);

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

        private User Map(RegisterModel model)
        {
            return new User
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }

        private RegisterModel Map(User model)
        {
            return new RegisterModel
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }
    }
}
