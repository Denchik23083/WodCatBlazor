using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsPage
    {
        [Inject] private IWorkoutsService WorkoutsService { get; set; } = null!;

        public IEnumerable<Workouts> Workouts { get; set; } = new List<Workouts>();

        protected override async Task OnInitializedAsync()
        {
            Workouts = await WorkoutsService.GetAllWorkouts();
        }
    }
}
