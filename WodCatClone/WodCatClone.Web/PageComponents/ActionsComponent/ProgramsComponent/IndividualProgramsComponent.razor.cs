using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsComponent
    {
        [Parameter] public Programs Programs { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Url = string.Empty;

        public Halls Hall { get; set; }

        public string HallEmblem { get; set; }

        protected override void OnInitialized()
        {
            Url = $"programs/{Programs.Id}";
            if (Programs.HallId is not null)
            {
                Hall = HallsService.GetHall(Programs.HallId);
                HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            }
        }

        protected override void OnParametersSet()
        {
            Url = $"programs/{Programs.Id}";
            if (Programs.HallId is not null)
            {
                Hall = HallsService.GetHall(Programs.HallId);
                HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            }
        }

        public void LinkHall(int id) => NavigationManager.NavigateTo($"/gymboxs/{id}");
    }
}
