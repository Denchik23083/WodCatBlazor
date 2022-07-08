using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public Events Event { get; set; }

        public Workouts Workout { get; set; }

        public IEnumerable<User> Users { get; set; }

        public bool DisplayEvent { get; set; } = true;

        public bool DisplayEventWorkoutExercise { get; set; }

        public bool DisplayUser { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }
        
        protected override void OnInitialized()
        {
            Event = EventsService.GetEvent(EventId);
            Users = EventsService.GetAllEventsUsers(EventId);
            Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();
        }

        protected override void OnParametersSet()
        {
            Event = EventsService.GetEvent(EventId);
            Users = EventsService.GetAllEventsUsers(EventId);
            Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void DisplayEvents()
        {
            DisplayEvent = true;
            DisplayUser = false;
            DisplayEventWorkoutExercise = false;
        }

        public void DisplayUsers()
        {
            DisplayEvent = false;
            DisplayUser = true;
            DisplayEventWorkoutExercise = false;
        }

        public void DisplayEventsWorkoutsExercises()
        {
            DisplayEvent = false;
            DisplayUser = false;
            DisplayEventWorkoutExercise = true;
        }
    }
}
