using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsWorkoutsExercisesComponent
    {
        [Parameter] public WorkoutsExercises? WorkoutsExercises { get; set; } = new();

        public Exercises? Exercise { get; set; } = new();

        public string? Work { get; set; }

        protected override void OnInitialized()
        {
            Work = WorkoutsExercises!.Work;
            Exercise = WorkoutsExercises.Exercises!;
        }
    }
}
