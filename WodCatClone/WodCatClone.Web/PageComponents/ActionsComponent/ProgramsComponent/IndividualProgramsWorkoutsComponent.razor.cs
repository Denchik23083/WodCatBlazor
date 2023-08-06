using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsWorkoutsComponent
    {
        [Parameter] public ProgramsWorkouts ProgramsWorkouts { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public Workouts Workout { get; set; }

        protected override void OnInitialized()
        {
            Workout = WorkoutsService.GetWorkout(ProgramsWorkouts.WorkoutsId);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(ProgramsWorkouts.WorkoutsId);
        }
    }
}
