using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    public partial class IndividualExercisesComponent
    {
        [Parameter] public Exercises Exercise { get; set; } = new();

        public string Url = string.Empty;

        protected override void OnInitialized()
        {
            Url = $"exercises/{Exercise.Id}";
        }
    }
}
