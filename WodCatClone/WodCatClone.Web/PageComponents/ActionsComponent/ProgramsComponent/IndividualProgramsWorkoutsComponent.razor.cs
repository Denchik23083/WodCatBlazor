using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsWorkoutsComponent
    {
        [Parameter] public ProgramsWorkouts ProgramsWorkouts { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }
        
        public Workouts Workout { get; set; }

        public string[] WorkoutsExercises { get; set; }

        protected override void OnInitialized()
        {
            Workout = WorkoutsService.GetWorkout(ProgramsWorkouts.WorkoutsId);
            WorkoutsExercises = Workout.Exercises.Split(",");
        }
    }
}
