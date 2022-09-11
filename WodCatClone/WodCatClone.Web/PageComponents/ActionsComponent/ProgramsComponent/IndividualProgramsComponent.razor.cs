using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsComponent
    {
        [Parameter] public Programs Program { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string Url = string.Empty;

        public Halls Hall { get; set; }

        public string HallEmblem { get; set; }

        public string Image { get; set; }

        public int Subscribers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Url = $"programs/{Program.Id}";
            if (Program.HallId is not null)
            {
                Hall = await HallsService.GetHall(Program.HallId);
                HallEmblem = await HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Program.ProgramsEmblemId is not null)
            {
                Image = await ProgramsService.GetImage(Program.ProgramsEmblemId);
            }

            Subscribers = await ProgramsService.Subscribers(Program.Id);
        }

        protected override async Task OnParametersSetAsync()
        {
            Url = $"programs/{Program.Id}";
            if (Program.HallId is not null)
            {
                Hall = await HallsService.GetHall(Program.HallId);
                HallEmblem = await HallsService.GetImage(Hall.EmblemHallId);
            }
            if (Program.ProgramsEmblemId is not null)
            {
                Image = await ProgramsService.GetImage(Program.ProgramsEmblemId);
            }

            Subscribers = await ProgramsService.Subscribers(Program.Id);
        }

        public void LinkHall(int id) => NavigationManager.NavigateTo($"/gymboxs/{id}");
    }
}
