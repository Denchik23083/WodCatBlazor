using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ProgramsPage
{
    public partial class ProgramsDetailsPage
    {
        [Parameter] public int ProgramId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public Programs Program { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            Program = ProgramsService.GetProgram(ProgramId);
            IsLoginUser = UserService.IsLoginUser();
        }

        public void NeedLogin() => NavigationManager.NavigateTo("/login");

        public void BeginProgram()
        {

        }
    }
}
