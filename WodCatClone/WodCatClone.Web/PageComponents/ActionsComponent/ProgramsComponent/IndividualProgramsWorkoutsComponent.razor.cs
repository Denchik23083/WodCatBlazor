using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsWorkoutsComponent
    {
        [Parameter] public ProgramsWorkouts? ProgramsWorkouts { get; set; } = new();

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();

        public Workouts Workout { get; set; } = new();

        protected override void OnInitialized()
        {
            Workout = ProgramsWorkouts!.Workouts!;
            WorkoutsExercises = ProgramsWorkouts.Workouts!.WorkoutsExercises!;
        }
    }
}
