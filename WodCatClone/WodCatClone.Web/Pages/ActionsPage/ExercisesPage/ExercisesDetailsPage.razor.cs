using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesDetailsPage
    {
        [Parameter] public int ExerciseId { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public User? User { get; set; } = new();

        public Exercises? Exercise { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();

            Exercise = await ExercisesService.GetExerciseAsync(ExerciseId);

            if (Exercise is null)
            {
                NavigationManager.NavigateTo("/exercises");
            }
        }
    }
}
