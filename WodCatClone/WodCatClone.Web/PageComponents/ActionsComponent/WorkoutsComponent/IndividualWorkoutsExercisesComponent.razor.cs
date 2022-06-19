﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ExercisesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class IndividualWorkoutsExercisesComponent
    {
        [Parameter] public WorkoutsExercises WorkoutsExercises { get; set; }

        [Parameter] public bool IsLink { get; set; }

        [Parameter] public string Color { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Exercises Exercises { get; set; }

        public int? CountRepeats { get; set; }

        protected override void OnInitialized()
        {
            CountRepeats = WorkoutsExercises.CountRepeats;
            Exercises = ExercisesService.GetExercise(WorkoutsExercises.ExercisesId);
        }
    }
}