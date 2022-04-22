using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualResultWorkouts
    {
        [Parameter] public ResultWorkouts ResultWorkout { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser(ResultWorkout.UserId);
        }
    }
}
