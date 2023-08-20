using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsExercisesComponent
    {
        [Parameter] public WorkoutsExercises WorkoutsExercises { get; set; } = new();

        [Parameter] public bool IsLink { get; set; }

        [Parameter] public string? Color { get; set; }

        public Exercises? Exercise { get; set; } = new();

        public string? Work { get; set; }

        protected override void OnInitialized()
        {
            Work = WorkoutsExercises.Work;
            Exercise = WorkoutsExercises.Exercises;
        }
    }
}
