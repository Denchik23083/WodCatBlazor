using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExerciseService;

namespace WodCatClone.Web.Pages.ActionsPage.ExercisesPage
{
    public partial class ExercisesPage
    {
        [Inject] private IExercisesService _service { get; set; }

        private IEnumerable<Exercises> Exercises { get; set; }

        public bool IsDisplay { get; set; }

        protected override void OnInitialized()
        {
            Exercises = _service.GetAllExercises();
        }
    }
}
