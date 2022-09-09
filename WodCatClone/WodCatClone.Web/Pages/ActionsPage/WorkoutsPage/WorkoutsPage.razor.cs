using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsPage
    {
        [Inject] private IWorkoutsService WorkoutsService { get; set; }

        public IEnumerable<Workouts> Workouts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Workouts = await WorkoutsService.GetAllWorkouts();
        }
    }
}
