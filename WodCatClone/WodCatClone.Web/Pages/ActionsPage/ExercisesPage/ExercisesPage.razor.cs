using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesPage
    {
        [Inject] public IExercisesService ExercisesService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Exercises> Exercises { get; set; } = new List<Exercises>();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();
            Exercises = await ExercisesService.GetAllExercisesAsync();
        }
    }
}
