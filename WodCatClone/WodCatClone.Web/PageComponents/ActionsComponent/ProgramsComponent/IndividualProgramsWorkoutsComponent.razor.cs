using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsWorkoutsComponent
    {
        [Parameter] public ProgramsWorkouts ProgramsWorkouts { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public Workouts Workout { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Workout = await WorkoutsService.GetWorkout(ProgramsWorkouts.WorkoutsId);
            WorkoutsExercises = await WorkoutsService.GetAllWorkoutsExercises(ProgramsWorkouts.WorkoutsId);
        }
    }
}
