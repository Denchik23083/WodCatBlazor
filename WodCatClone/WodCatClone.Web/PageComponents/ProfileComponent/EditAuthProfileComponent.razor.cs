using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditAuthProfileComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IAuthService AuthService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Image { get; set; }

        public Register AuthUser { get; set; }

        protected override void OnInitialized()
        {
            AuthUser = Map(User);

            if (User.GenderId is not null)
            {
                Image = UserService.GetGender(User.GenderId).Image;
            }
        }

        public void Auth()
        {
            if (AuthUser.Password == AuthUser.ConfirmPassword)
            {
                var result = UserService.UpdateAuth(Map(AuthUser), User.Id);

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

        private User Map(Register model)
        {
            return new User
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }

        private Register Map(User model)
        {
            return new Register
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }
    }
}
