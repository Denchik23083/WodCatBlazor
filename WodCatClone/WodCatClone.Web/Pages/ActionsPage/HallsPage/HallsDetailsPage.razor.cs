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

        protected override void OnInitialized()
        {
            Hall = HallsService.GetHall(HallId);
        }
    }
}
