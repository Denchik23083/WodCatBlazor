using System.Collections.Generic;
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

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public ConfirmRemoveHall ConfirmRemoveHall { get; set; }

        public Halls Hall { get; set; }

        public IEnumerable<User> Users { get; set; }

        public string Image { get; set; }

        public string[] Type { get; set; }

        public bool IsLoginUser { get; set; }

        public int Athletes { get; set; }

        public bool DisplayLocation { get; set; } = true;

        public bool DisplayUsers { get; set; }

        public User User { get; set; } 

        public int Value = 0;

        public string Top = "notLoginTop";

        protected override void OnInitialized()
        {
            Hall = HallsService.GetHall(HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
            Type = Hall.Type.Split(",");
            IsLoginUser = UserService.IsLoginUser();
            User = UserService.GetUser();
            Users = HallsService.GetAllHallsUsers(HallId);
            Athletes = HallsService.Athlete(Hall.Id);

            if (IsLoginUser) Top = "loginTop";
        }

        protected override void OnParametersSet()
        {
            Hall = HallsService.GetHall(HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
            Type = Hall.Type.Split(",");
            IsLoginUser = UserService.IsLoginUser();
            User = UserService.GetUser();
            Users = HallsService.GetAllHallsUsers(HallId);
            Athletes = HallsService.Athlete(Hall.Id);

            if (IsLoginUser) Top = "loginTop";
        }

        public void Edit() => NavigationManager.NavigateTo($"/gymboxs/{HallId}/edit");

        public void OnShow() => ConfirmRemoveHall.Show(); 

        public void OnCancel() => ConfirmRemoveHall.Hide(); 

        public void Join()
        {
            var result = HallsService.JoinHall(Hall.Id, User);

            if (result)
            {
                Athletes = HallsService.Athlete(Hall.Id);
                NavigationManager.NavigateTo($"/gymboxs/{HallId}");
            }
        }
        
        public void Exit()
        {
            var result = HallsService.ExitHall(Hall.Id, User);

            if (result)
            {
                Athletes = HallsService.Athlete(Hall.Id);
                NavigationManager.NavigateTo($"/gymboxs/{HallId}");
            }
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
    }
}
