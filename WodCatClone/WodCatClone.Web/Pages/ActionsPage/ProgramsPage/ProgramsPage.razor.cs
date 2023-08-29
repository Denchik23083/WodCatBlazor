using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ProgramsPage
{
    public partial class ProgramsPage
    {
        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Programs> Programs { get; set; } = new List<Programs>();

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser();
            Programs = await ProgramsService.GetAllPrograms();
        }
    }
}
