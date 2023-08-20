using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsPage
    {
        [Inject] public IHallsService HallsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        public bool IsLoginUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Halls = await HallsService.GetAllHalls();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Add() => NavigationManager.NavigateTo("/gymboxs/add");
    }
}
