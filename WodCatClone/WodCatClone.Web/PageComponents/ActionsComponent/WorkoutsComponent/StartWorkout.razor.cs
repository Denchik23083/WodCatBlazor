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

        private string _seconds = "00";
        private string _minutes = "00";

        public bool IsShowStart = true;
        public bool IsMinutesDone = false;

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
            var minutesInWorkout = int.Parse(Workout.Minutes);
            var secondsInWorkout = int.Parse(Workout.Seconds);
            var seconds = int.Parse(_seconds);
            var minutes = int.Parse(_minutes);

            if (seconds == 60)
            {
                seconds = 0;
                _seconds = $"0{seconds}";

                if (minutes != minutesInWorkout)
                {
                    minutes++;
                    _minutes = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                    IsMinutesDone = true;
                }
            }

            if (!IsMinutesDone)
            {
                if (seconds < 60)
                {
                    seconds++;
                    _seconds = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                }
                else
                {
                    _timer.Stop();
                }
            }
            else
            {
                if (seconds < secondsInWorkout)
                {
                    seconds++;
                    _seconds = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                }
                else
                {
                    _timer.Stop();
                }
            }

            InvokeAsync(StateHasChanged);
        }

        public void Stop() => _timer.Stop();

        public void Continue() => _timer.Start();

        public void Reset()
        {
            _timer.Stop();
            _seconds = "00";
            _minutes = "00";
        }
    }
}
