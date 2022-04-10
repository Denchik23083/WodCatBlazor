using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsPage
    {
        public IEnumerable<Halls> Halls { get; set; }

        public bool IsLoginUser { get; set; }  

        [Inject] public IHallsService _service { get; set; }

        [Inject] public IUserService _userService { get; set; }

        [Inject] public NavigationManager _navigationManager { get; set; }

        protected override void OnInitialized()
        {
            Halls = _service.GetAllHalls();
            IsLoginUser = _userService.IsLoginUser();
        }

        public void Add() => _navigationManager.NavigateTo("/gymboxs/add");
    }
}
