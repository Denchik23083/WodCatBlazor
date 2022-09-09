using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsExercisesComponent
    {
        [Parameter] public WorkoutsExercises WorkoutsExercises { get; set; }

        [Parameter] public bool IsLink { get; set; }

        [Parameter] public string Color { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        public Exercises Exercise { get; set; }

        public string Work { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Work = WorkoutsExercises.Work;
            Exercise = await ExercisesService.GetExercise(WorkoutsExercises.ExercisesId);
        }
    }
}
