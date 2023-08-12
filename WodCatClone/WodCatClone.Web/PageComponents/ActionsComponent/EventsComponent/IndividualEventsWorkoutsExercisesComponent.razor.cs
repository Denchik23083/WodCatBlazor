using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class IndividualEventsWorkoutsExercisesComponent
    {
        [Parameter] public WorkoutsExercises WorkoutsExercises { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        public Exercises Exercise { get; set; }

        public string Work { get; set; }

        public string Width = "100%";

        public string Height = "200";

        protected override void OnInitialized()
        {
            Work = WorkoutsExercises.Work;
            //Exercise = ExercisesService.GetExercise(WorkoutsExercises.ExercisesId);
        }
    }
}
