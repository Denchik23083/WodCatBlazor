using System;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService.ResultWorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class ResultWorkoutsComponent
    {
        [Parameter] public int WorkoutId { get; set; }

        [Inject] public IResultWorkoutsService ResultWorkoutsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public DateTime Time { get; set; }

        public ResultWorkouts ResultWorkouts = new();

        public void Result()
        {
            FillData();

            var result = ResultWorkoutsService.AddResultWorkouts(ResultWorkouts);

            if (result)
            {
                ResetAll();
            }

            NavigationManager.NavigateTo($"/workouts/{WorkoutId}", true);
        }

        private bool _oneFascination, _twoFascination, _threeFascination, _fourFascination, _fiveFascination;
        private bool _oneLoad, _twoLoad, _threeLoad, _fourLoad, _fiveLoad;

        public int ResultFascination { get; set; }

        public int ResultLoad { get; set; }

        public void ResetAll()
        {
            ResetFascinationLoadStars();

            ResultWorkouts.Fascination = 0;
            ResultWorkouts.Load = 0;
            ResultWorkouts.Repeat = 0;
            ResultWorkouts.PublishDate = new DateTime();
            ResultWorkouts.Comment = string.Empty;
            Time = new DateTime();
        }

        public void ResetFascinationLoadStars()
        {
            _oneFascination = false;
            _twoFascination = false;
            _threeFascination = false;
            _fourFascination = false;
            _fiveFascination = false;
            _oneLoad = false;
            _twoLoad = false;
            _threeLoad = false;
            _fourLoad = false;
            _fiveLoad = false;
        }

        public void FillData()
        {
            ResultFascinationStars();
            ResultLoadStars();

            ResultWorkouts.Time = new TimeSpan(Time.Hour, Time.Minute, Time.Second);

            ResultWorkouts.Comment ??= "";

            ResultWorkouts.Fascination = ResultFascination;
            ResultWorkouts.Load = ResultLoad;
            ResultWorkouts.WorkoutId = WorkoutId;
        }

        private void ResultFascinationStars()
        {
            if (_oneFascination) ResultFascination = 1;
            else if (_twoFascination) ResultFascination = 2;
            else if (_threeFascination) ResultFascination = 3;
            else if (_fourFascination) ResultFascination = 4;
            else if (_fiveFascination) ResultFascination = 5;
            else ResultFascination = 0;
        }

        private void ResultLoadStars()
        {
            if (_oneLoad) ResultLoad = 1;
            else if (_twoLoad) ResultLoad = 2;
            else if (_threeLoad) ResultLoad = 3;
            else if (_fourLoad) ResultLoad = 4;
            else if (_fiveLoad) ResultLoad = 5;
            else ResultLoad = 0;
        }
    }
}
