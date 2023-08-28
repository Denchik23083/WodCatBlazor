using System.Timers;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class StartWorkout
    {
        [Parameter] public Workouts Workout { get; set; } = new();

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();

        public bool DisplayStartWorkout { get; set; }
        
        public static readonly System.Timers.Timer Timer = new(1000);

        public bool IsShowStart = true;

        public TimeSpan Time { get; set; }

        public void Show() => DisplayStartWorkout = true;

        public void Hide() => DisplayStartWorkout = false;

        public void StartTimer()
        {
            IsShowStart = false;
            Timer.Elapsed += CountDownTimer!;
            Timer.Start();
        }

        public void CountDownTimer(object source, ElapsedEventArgs e)
        {
            if (Time < Workout.Time)
            {
                Time = Time.Add(new TimeSpan(00, 00, 01));
                
            }
            else
            {
                Timer.Stop();
            }

            InvokeAsync(StateHasChanged);
        }

        public void Stop() => Timer.Stop();

        public void Continue() => Timer.Start();

        public void Reset()
        {
            Timer.Stop();
            Time = new TimeSpan();
        }
    }
}
