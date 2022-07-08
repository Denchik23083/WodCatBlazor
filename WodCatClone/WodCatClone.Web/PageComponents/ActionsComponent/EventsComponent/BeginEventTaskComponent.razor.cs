using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class BeginEventTaskComponent
    {
        [Parameter] public Events Event { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public string Image { get; set; }

        public Workouts Workout { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            Image = EventsService.GetImage(Event.EventsEmblemId);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Event.WorkoutId);
            Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
        }
    }
}
