using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsDetailsPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Halls Hall { get; set; }

        public string Image { get; set; }

        public string[] Type { get; set; }

        public bool UserJoin { get; set; }

        public bool HallAthlete { get; set; }

        public bool IsLoginUser { get; set; }

        public int Value = 0;

        protected override void OnInitialized()
        {
            Hall = HallsService.GetHall(HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
            Type = Hall.Type.Split(",");
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Join()
        {
            UserJoin = UserService.Join(Hall.Id);
            HallAthlete = HallsService.AddAthlete(Hall.Id);

            if (UserJoin && HallAthlete)
            {
                NavigationManager.NavigateTo($"/gymboxs/{HallId}", true);
            }
        }
    }
}
