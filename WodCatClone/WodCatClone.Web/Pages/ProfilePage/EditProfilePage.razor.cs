using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class EditProfilePage
    {
        [Parameter] public string NickName { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }

        public User UserEnter { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IsLoginUser = UserService.IsLoginUser();

            User = UserService.GetUser(NickName);
            UserEnter = UserService.GetUser();

            if (User is null || UserEnter is null)
            {
                NavigationManager.NavigateTo("/");
            }
            else
            {
                if (!IsLoginUser || User.NickName != UserEnter.NickName)
                {
                    NavigationManager.NavigateTo("/");
                }
            }
        }

        public void BackToProfile() => NavigationManager.NavigateTo($"/profile/{NickName}");
    }
}
