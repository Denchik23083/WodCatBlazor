using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    public partial class IndividualExercisesComponent
    {
        [Parameter] public Exercises Exercises { get; set; }

        public string Url = string.Empty;

        protected override void OnInitialized()
        {
            Url = $"exercises/{Exercises.Id}";
        }
    }
}
