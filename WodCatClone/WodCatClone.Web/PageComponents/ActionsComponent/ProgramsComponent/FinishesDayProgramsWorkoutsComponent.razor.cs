using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class FinishesDayProgramsWorkoutsComponent
    {
        [Parameter] public bool IsEndOrNot { get; set; }

        [Parameter] public int ProgramId { get; set; }

        [Parameter] public User? User { get; set; } = new();

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IProgramsService ProgramsService { get; set; } = null!;
        
        public async Task FinishProgram()
        {
            var result = await ProgramsService.StopProgram(ProgramId, User!, true);

            if (result)
            {
                NavigationManager.NavigateTo("/programs");
            }
        }
    }
}
