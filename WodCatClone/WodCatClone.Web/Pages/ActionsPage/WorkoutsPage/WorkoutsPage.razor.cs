using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.Pages.ActionsPage.WorkoutsPage
{
    public partial class WorkoutsPage
    {
        [Inject] private IWorkoutsService _service { get; set; }

        public IEnumerable<Workouts> Workouts { get; set; }

        protected override void OnInitialized()
        {
            Workouts = _service.GetAllWorkouts();
        }
    }
}
