using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsComponent
    {
        [Parameter] public Programs Programs { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Url = string.Empty;

        public Halls Hall { get; set; }

        public string HallEmblem { get; set; }

        public string Image { get; set; }

        public int Subscribers { get; set; }

        protected override void OnInitialized()
        {
            Url = $"programs/{Programs.Id}";
            if (Programs.HallId is not null)
            {
                Hall = HallsService.GetHall(Programs.HallId);
                HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Programs.ProgramsEmblemId is not null)
            {
                Image = ProgramsService.GetImage(Programs.ProgramsEmblemId);
            }

            Subscribers = ProgramsService.Subscribers(Programs.Id);
        }

        protected override void OnParametersSet()
        {
            Url = $"programs/{Programs.Id}";
            if (Programs.HallId is not null)
            {
                Hall = HallsService.GetHall(Programs.HallId);
                HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Programs.ProgramsEmblemId is not null)
            {
                Image = ProgramsService.GetImage(Programs.ProgramsEmblemId);
            }

            Subscribers = ProgramsService.Subscribers(Programs.Id);
        }

        public void LinkHall(int id) => NavigationManager.NavigateTo($"/gymboxs/{id}");
    }
}
