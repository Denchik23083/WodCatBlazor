using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class ListWorkoutsComponent
    {
        [Parameter] public IEnumerable<Workouts> ListOfItems { get; set; } = new List<Workouts>();
    }
}
