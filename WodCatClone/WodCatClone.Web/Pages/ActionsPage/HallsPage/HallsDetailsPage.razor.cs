using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.Pages.ActionsPage.HallsPage
{
    public partial class HallsDetailsPage
    {
        [Parameter] public int HallId { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        public Halls Hall { get; set; }

        public string Image { get; set; }

        public string[] Type { get; set; }

        public int Value = 0;

        protected override void OnInitialized()
        {
            Hall = HallsService.GetHall(HallId);
            Image = HallsService.GetImage(Hall.EmblemHallId);
            Type = Hall.Type.Split(",");
        }
    }
}
