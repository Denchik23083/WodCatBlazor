﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsComponent
    {
        [Parameter] public Workouts Workouts { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        public IEnumerable<WorkoutsExercises> WorkoutsExercises { get; set; }
        
        public string[] WorkoutsCategory { get; set; }

        public string Image { get; set; }

        public string _url = string.Empty;

        public int Value { get; set; }

        public int ResultWorkoutsCount { get; set; }

        protected override void OnInitialized()
        {
            Value = 0;
            Image = WorkoutsService.GetImage(Workouts.EmblemHallId);
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetCountResultWorkouts(Workouts.Id);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workouts.Id);
        }

        protected override void OnParametersSet()
        {
            Value = 0;
            Image = WorkoutsService.GetImage(Workouts.EmblemHallId);
            WorkoutsCategory = Workouts.Category.Split(",");
            ResultWorkoutsCount = ResultWorkoutsService.GetCountResultWorkouts(Workouts.Id);
            WorkoutsExercises = WorkoutsService.GetAllWorkoutsExercises(Workouts.Id);
        }

        public void Id()
        {
            _url = $"workouts/{Workouts.Id}";
            NavigationManager.NavigateTo(_url);
        }
    }
}
