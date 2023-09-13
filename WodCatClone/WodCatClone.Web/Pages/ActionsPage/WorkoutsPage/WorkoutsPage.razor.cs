using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsPage
    {
        [Inject] public IWorkoutsService WorkoutsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();
            Workouts = await WorkoutsService.GetAllWorkoutsAsync();
        }
    }
}
