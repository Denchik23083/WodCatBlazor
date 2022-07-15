using System;
using System.Collections.Generic;
using System.Timers;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class StartWorkout
    {
        [Parameter] public Workouts Workout { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }

        public bool DisplayStartWorkout { get; set; }

        private static Timer _timer = new(1000);

        public bool IsShowStart = true;

        public TimeSpan Time { get; set; }

        public void Show() => DisplayStartWorkout = true;

        public void Hide() => DisplayStartWorkout = false;

        public void StartTimer()
        {
            IsShowStart = false;
            _timer.Elapsed += CountDownTimer;
            _timer.Start();
        }

        public void CountDownTimer(Object source, ElapsedEventArgs e)
        {
            if (Time < Workout.Time)
            {
                Time = Time.Add(new TimeSpan(00, 00, 01));
                
            }
            else
            {
                _timer.Stop();
            }

            InvokeAsync(StateHasChanged);
        }

        public void Stop() => _timer.Stop();

        public void Continue() => _timer.Start();

        public void Reset()
        {
            _timer.Stop();
            Time = new TimeSpan();
        }
    }
}
