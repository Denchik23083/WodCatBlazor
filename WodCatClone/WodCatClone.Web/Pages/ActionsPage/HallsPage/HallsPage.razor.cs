using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsPage
    {
        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public bool IsLoginUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();
            
            IsLoginUser = await UserService.IsLoginUserAsync();

            Halls = await HallsService.GetAllHallsAsync();
        }

        public void Add() => NavigationManager.NavigateTo("/gymboxs/add");
    }
}
