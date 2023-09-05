using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class DayProgramsWorkoutsComponent
    {
        [Parameter] public Programs? Program { get; set; } = new();

        [Parameter] public User? User { get; set; } = new();

        [Parameter] public int ProgramId { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();

        public Workouts? Workout { get; set; } = new();

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            var programTimeUser = Program!.ProgramTimeUsers!.FirstOrDefault(b => b.ProgramsId == ProgramId && b.UserId == User!.Id);

            if (programTimeUser is not null)
            {
                var day = (DateTime.Now - programTimeUser.BeginProgramDate).Days;

                if (Program!.ProgramsWorkouts is not null)
                {
                    var programWorkout = Program!.ProgramsWorkouts!.ElementAtOrDefault(day)!;

                    if (programWorkout is not null)
                    {
                        Workout = programWorkout!.Workouts!;
                        WorkoutsExercises = programWorkout.Workouts!.WorkoutsExercises!;
                    }
                }
            }
        }
    }
}
