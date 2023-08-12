using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesDetailsPage
    {
        [Parameter] public int ExerciseId { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public Exercises? Exercise { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Exercise = await ExercisesService.GetExercise(ExerciseId);

            if (Exercise is null)
            {
                NavigationManager.NavigateTo("/exercises");
            }
        }
    }
}
