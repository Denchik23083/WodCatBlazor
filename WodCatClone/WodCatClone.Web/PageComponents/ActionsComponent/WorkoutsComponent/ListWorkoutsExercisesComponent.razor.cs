using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class ListWorkoutsExercisesComponent
    {
        [Parameter] public IEnumerable<WorkoutsExercises> ListOfItems { get; set; } = new List<WorkoutsExercises>();

        [Parameter] public bool IsLink { get; set; }

        [Parameter] public string? Color { get; set; }
    }
}
