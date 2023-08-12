using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesPage
    {
        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        public IEnumerable<Exercises> Exercises { get; set; } = new List<Exercises>();

        protected override async Task OnInitializedAsync()
        {
            Exercises = await ExercisesService.GetAllExercises();
        }
    }
}
