using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class EditProfilePage
    {
        [Parameter] public string NickName { get; set; } = "";

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public bool IsLoginUser { get; set; }

        public User? User { get; set; } = new();

        public User? UserEnter { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            IsLoginUser = UserService.IsLoginUser();

            User = await UserService.GetUser(NickName);
            UserEnter = UserService.GetUser();

            Halls = await HallsService.GetAllHalls();

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
