using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;

namespace WodCatClone.Web.Pages.ActionsPage.ProgramsPage
{
    public partial class ProgramsPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; }

        public IEnumerable<Programs> Programs { get; set; }

        protected override void OnInitialized()
        {
            Programs = ProgramsService.GetAllPrograms();
        }
    }
}
