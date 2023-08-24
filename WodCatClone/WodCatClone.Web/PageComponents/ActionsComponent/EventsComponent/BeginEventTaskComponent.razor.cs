﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.WorkoutsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.EventsComponent
{
    public partial class BeginEventTaskComponent
    {
        [Parameter] public Events Event { get; set; }

        [Inject] public IEventsService EventsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public string Image { get; set; }

        public Workouts Workout { get; set; }

        public User User { get; set; }

        public DateTime Time { get; set; }

        public EventTimeUser EventTimeUser { get; set; }

        public EventTimeUser AddEventTimeUser = new();

        protected override void OnInitialized()
        {
            Image = EventsService.GetImage(Event.EventsEmblemId);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Event.WorkoutId);
            Workout = WorkoutsService.GetWorkout(Event.WorkoutId);
            User = UserService.GetUser();
            EventTimeUser = EventsService.GetEventTimeUser(Event.Id, User.Id);
        }

        public void SubmitTime()
        {
            AddEventTimeUser.Time = new TimeSpan(Time.Hour, Time.Minute, Time.Second);
            AddEventTimeUser.UserId = User.Id;
            AddEventTimeUser.EventsId = Event.Id;

            var result = EventsService.AddEventTimeUser(AddEventTimeUser);

            if (result)
            {
                NavigationManager.NavigateTo($"/events/{Event.Id}", true);
            }
        }
    }
}
