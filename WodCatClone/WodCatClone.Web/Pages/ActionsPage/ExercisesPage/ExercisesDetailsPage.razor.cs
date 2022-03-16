using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExerciseService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesDetailsPage
    {
        [Parameter] public int ExerciseId { get; set; }

        private Exercises Exercise { get; set; }

        [Inject] public IExercisesService _service { get; set; }

        protected override void OnInitialized()
        {
            Exercise = _service.GetExercise(ExerciseId);
        }
    }
}
