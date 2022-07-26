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

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
        }

        public void FinishProgram()
        {
            var result = ProgramsService.StopProgram(ProgramId, User, true);

            if (result)
            {
                NavigationManager.NavigateTo("/programs");
            }
        }
    }
}
