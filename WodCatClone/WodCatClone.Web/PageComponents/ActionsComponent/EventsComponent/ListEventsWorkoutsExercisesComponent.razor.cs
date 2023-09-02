using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class ListEventsWorkoutsExercisesComponent
    {
        [Parameter] public IEnumerable<WorkoutsExercises> ListOfItems { get; set; } = new List<WorkoutsExercises>();
    }
}
