using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesPage
    {
        [Inject] private IExercisesService ExercisesService { get; set; }

        private IEnumerable<Exercises> Exercises { get; set; }

        protected override void OnInitialized()
        {
            Exercises = ExercisesService.GetAllExercises();
        }
    }
}
