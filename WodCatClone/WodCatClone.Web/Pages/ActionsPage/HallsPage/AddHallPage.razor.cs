using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class AddHallPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;
        
        [Inject] public IHallsService HallsService { get; set; } = null!;

        public IEnumerable<HallEmblem> HallEmblem { get; set; } = new List<HallEmblem>();

        public bool IsLoginUser { get; set; }

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();

            IsLoginUser = await UserService.IsLoginUserAsync();

            HallEmblem = await HallsService.GetAllHallEmblemAsync();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void BackToGymList() => NavigationManager.NavigateTo("/gymboxs");
    }
}
