using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class EditHallPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        public bool IsLoginUser { get; set; }

        public IEnumerable<HallEmblem> HallEmblem { get; set; } = new List<HallEmblem>();

        public Halls? Hall { get; set; } = new();

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();

            Hall = await HallsService.GetHall(HallId);
            if (Hall is null)
            {
                NavigationManager.NavigateTo("/gymboxs");
            }
            else
            {
                if (!IsLoginUser)
                {
                    NavigationManager.NavigateTo("/login");
                }

                if (User?.Id != Hall.UserId)
                {
                    NavigationManager.NavigateTo("/gymboxs");
                }
            }

            HallEmblem = await HallsService.GetAllHallEmblem();
        }

        public void BackToGymList() => NavigationManager.NavigateTo($"/gymboxs/{HallId}");
    }
}
