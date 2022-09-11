using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsPage
    {
        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public IEnumerable<Halls> Halls { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            Halls = HallsService.GetAllHalls();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Add() => NavigationManager.NavigateTo("/gymboxs/add");
    }
}
