﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workout { get; set; } = new();

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; } = new List<WorkoutsExercises>();
        
        public string[]? WorkoutsCategory { get; set; }

        public string? Image { get; set; }

        public string Url = string.Empty;

        public int Value { get; set; }

        public int ResultWorkoutsCount { get; set; }

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
            Value = 0;
            Image = Workout.Halls!.EmblemHall!.Image;
            WorkoutsCategory = Workout.Category!.Split(",");
            ResultWorkoutsCount = Workout.ResultWorkouts!.Count;
            WorkoutsExercises = Workout.WorkoutsExercises!;
        }

        public void Id()
        {
            Url = $"workouts/{Workout.Id}";
            NavigationManager.NavigateTo(Url);
        }
    }
}
