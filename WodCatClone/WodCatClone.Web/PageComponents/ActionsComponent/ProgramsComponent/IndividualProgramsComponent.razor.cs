using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsComponent
    {
        [Parameter] public Programs Program { get; set; } = new();

        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public string Url = string.Empty;

        public Halls? Hall { get; set; }

        public string? HallImage { get; set; }

        public string? Image { get; set; }

        public int Subscribers { get; set; }

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            Url = $"programs/{Program.Id}";
            if (Program.Halls is not null)
            {
                Hall = Program.Halls!;
                HallImage = Program.Halls!.EmblemHall!.Image;
            }
            Image = Program.ProgramEmblem!.Image!;
            Subscribers = Program.Users!.Count;
        }

        public void LinkHall(int id) => NavigationManager.NavigateTo($"/gymboxs/{id}");
    }
}
