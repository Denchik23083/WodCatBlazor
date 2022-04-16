using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class IndividualHallsComponent
    {
        [Parameter] public Halls Hall { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        public string[] HallsType { get; set; }

        public string Image { get; set; }

        public string _url = string.Empty;
        public int value = 0;

        protected override void OnInitialized()
        {
            _url = $"gymboxs/{Hall.Id}";
            HallsType = Hall.Type.Split(",");
            Image = HallsService.GetImage(Hall.EmblemHallId);
        }
    }
}
