using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    public partial class ListExercisesComponent
    {
        [Parameter] public IEnumerable<Exercises> ListOfItems { get; set; } = new List<Exercises>();
    }
}
