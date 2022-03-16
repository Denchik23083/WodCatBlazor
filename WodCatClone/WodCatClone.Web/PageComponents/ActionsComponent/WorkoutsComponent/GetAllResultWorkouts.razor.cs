using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class GetAllResultWorkouts
    {
        [Parameter] public int WorkoutId { get; set; }

        [Inject] public IResultWorkoutsService _service { get; set; }

        [Inject] public IUserService _userService { get; set; }

        public IEnumerable<ResultWorkouts> ResultWorkouts { get; set; }

        public User user = new();

        protected override void OnInitialized()
        {
            ResultWorkouts = _service.GetAllResultWorkouts(WorkoutId);
            user = _userService.GetUser();
        }
    }
}
