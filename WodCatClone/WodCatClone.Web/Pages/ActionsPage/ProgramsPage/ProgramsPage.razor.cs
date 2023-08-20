using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;

namespace WodCatClone.Web.Pages.ActionsPage.ProgramsPage
{
    public partial class ProgramsPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();

        protected override async Task OnInitializedAsync()
        {
            Programs = await ProgramsService.GetAllPrograms();
        }
    }
}
