using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class GetAllResultWorkouts
    {
        [Parameter] public int WorkoutId { get; set; }

        [Parameter] public EventCallback IsDisplayDialog { get; set; }

        [Parameter] public User? User { get; set; } = new();

        [Parameter] public IEnumerable<ResultWorkouts> ResultWorkouts { get; set; } = new List<ResultWorkouts>();
        
        public int ResultWorkoutId { get; set; }

        public void PostId(int itemId)
        {
            ResultWorkoutId = itemId;
        }
    }
}
