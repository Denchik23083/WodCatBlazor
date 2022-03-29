﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workouts { get; set; }

        [Inject] public NavigationManager _manager { get; set; }

        [Inject] public IResultWorkoutsService _service { get; set; }

        public string[] WorkoutsExercises { get; set; }

        public string[] WorkoutsCategory { get; set; }

        string _url = string.Empty;

        public int ResultWorkoutsCount { get; set; }

        protected override void OnInitialized()
        {
            WorkoutsExercises = Workouts.Exercises.Split(",");
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = _service.GetCountResultWorkouts(Workouts.Id);
        }

        public void Id()
        {
            _url = $"workouts/{Workouts.Id}";
            _manager.NavigateTo(_url);
        }
    }
}