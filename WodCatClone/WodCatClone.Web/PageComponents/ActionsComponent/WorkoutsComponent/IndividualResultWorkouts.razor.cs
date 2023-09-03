using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualResultWorkouts
    {
        [Parameter] public ResultWorkouts ResultWorkout { get; set; } = new();

        [Parameter] public User? User { get; set; } = new();

        public string? Image { get; set; }

        protected override void OnInitialized()
        {
            if (User is not null)
            {
                Image = User?.Gender!.Image;
            }
        }
    }
}
