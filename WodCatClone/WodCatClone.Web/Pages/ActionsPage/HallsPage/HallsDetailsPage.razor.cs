using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsDetailsPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public ConfirmRemoveHall? ConfirmRemoveHall { get; set; } = new();

        public Halls? Hall { get; set; } = new();

        public User? User { get; set; } = new();

        public IEnumerable<User> Users { get; set; } = new List<User>();

        public string? Image { get; set; }

        public string[]? Type { get; set; }

        public bool IsLoginUser { get; set; }

        public int Athletes { get; set; }

        public bool DisplayLocation { get; set; } = true;

        public bool DisplayUsers { get; set; }

        public int Value = 0;

        public string Top = "notLoginTop";

        protected override async Task OnInitializedAsync()
        {
            await FillOverrideFunctions();
        }

        protected override async Task OnParametersSetAsync()
        {
            await FillOverrideFunctions();
        }

        private async Task FillOverrideFunctions()
        {
            User = await UserService.GetUser();
            IsLoginUser = await UserService.IsLoginUser();

            Hall = await HallsService.GetHall(HallId);
            if (Hall is null)
            {
                NavigationManager.NavigateTo("/gymboxs");
            }
            else
            {
                Image = Hall.EmblemHall!.Image;
                
                if (IsLoginUser) Top = "loginTop";

                if (Hall.Type is not null)
                {
                    Type = Hall.Type.Split(",");
                }

                Users = Hall.Users!;
                Athletes = Users.Count();
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/gymboxs/{HallId}/edit");

        public void OnShow() => ConfirmRemoveHall!.Show(); 

        public void OnCancel() => ConfirmRemoveHall!.Hide(); 

        public async Task Join()
        {
            var result = await HallsService.JoinHall(Hall!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/gymboxs/{HallId}");
            }

            GetAthlete();
        }
        
        public async Task Exit()
        {
            var result = await HallsService.ExitHall(Hall!.Id, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/gymboxs/{HallId}");
            }

            GetAthlete();
        }

        public void DisplayWorkout()
        {
            DisplayLocation = true;
            DisplayUsers = false;
        }

        public void DisplayUser()
        {
            DisplayLocation = false;
            DisplayUsers = true;
        }

        private void GetAthlete()
        {
            Athletes = Hall!.Users!.Count;
        }
    }
}
