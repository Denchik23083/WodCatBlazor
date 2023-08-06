using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.EventsPage
{
    public partial class EventsDetailsPage
    {
        [Parameter] public int EventId { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Events Event { get; set; }

        public Workouts Workout { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<EventTimeUser> EventTimeUsers { get; set; }

        public bool DisplayEvent { get; set; } = true;

        public bool DisplayEventWorkoutExercise { get; set; }

        public bool DisplayUser { get; set; }

        public bool DisplayAward { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }
        
        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            Event = EventsService.GetEvent(EventId);
            if (Event is null || Event.EndDate < DateTime.Now)
            {
                NavigationManager.NavigateTo("/events", true);
            }
            else
            {
                Users = EventsService.GetAllEventsUsers(EventId);
                Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
                User = UserService.GetUser();
                EventTimeUsers = EventsService.GetAllEventTimeUsers(EventId);
                IsLoginUser = UserService.IsLoginUser();
            }
        }

        public void DisplayEvents()
        {
            DisplayEvent = true;
            DisplayUser = false;
            DisplayEventWorkoutExercise = false;
            DisplayAward = false;
        }

        public void DisplayUsers()
        {
            DisplayEvent = false;
            DisplayUser = true;
            DisplayEventWorkoutExercise = false;
            DisplayAward = false;
        }

        public void DisplayEventsWorkoutsExercises()
        {
            DisplayEvent = false;
            DisplayUser = false;
            DisplayEventWorkoutExercise = true;
            DisplayAward = false;
        }

        public void DisplayAwards()
        {
            DisplayEvent = false;
            DisplayUser = false;
            DisplayEventWorkoutExercise = false;
            DisplayAward = true;
        }
    }
}
