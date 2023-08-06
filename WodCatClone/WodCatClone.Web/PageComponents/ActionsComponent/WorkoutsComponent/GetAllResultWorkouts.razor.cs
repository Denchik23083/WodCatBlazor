using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class GetAllResultWorkouts
    {
        [Parameter] public int WorkoutId { get; set; }

        [Parameter] public EventCallback IsDisplayDialog { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public IUserService UserService { get; set; }
        
        public int ResultWorkoutId { get; set; }
        
        public IEnumerable<ResultWorkouts> ResultWorkouts { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            ResultWorkouts = ResultWorkoutsService.GetAllResultWorkouts(WorkoutId);
            User = UserService.GetUser();
        }

        public void PostId(int itemId)
        {
            ResultWorkoutId = itemId;
        }
    }
}
