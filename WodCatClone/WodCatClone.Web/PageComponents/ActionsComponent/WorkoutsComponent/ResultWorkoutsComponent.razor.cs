using System;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.WorkoutsService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class ResultWorkoutsComponent
    {
        [Parameter] public int WorkoutId { get; set; }

        [Inject] public IResultWorkoutsService _service { get; set; }

        [Inject] public NavigationManager _manager { get; set; }

        private ResultWorkouts _resultWorkouts = new();

        public void Result()
        {
            FillData();

            var result = _service.AddResultWorkouts(_resultWorkouts);

            if (result)
            {
                ResetAll();
            }

            _manager.NavigateTo($"/workouts/{WorkoutId}", true);
        }

        private bool _oneFascination, _twoFascination, _threeFascination, _fourFascination, _fiveFascination;
        private bool _oneLoad, _twoLoad, _threeLoad, _fourLoad, _fiveLoad;

        public int ResultFascination { get; set; }

        public int ResultLoad { get; set; }

        public void ResetAll()
        {
            ResetFascinationLoadStars();

            _resultWorkouts.Fascination = 0;
            _resultWorkouts.Load = 0;
            _resultWorkouts.Minutes = "0";
            _resultWorkouts.Seconds = "0";
            _resultWorkouts.Repeat = 0;
            _resultWorkouts.PublishDate = new DateTime();
            _resultWorkouts.Comment = string.Empty;
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

            _resultWorkouts.Minutes ??= "0";
            _resultWorkouts.Seconds ??= "0";
            _resultWorkouts.Comment ??= "";

            var minutes = int.Parse(_resultWorkouts.Minutes);
            var seconds = int.Parse(_resultWorkouts.Seconds);

            if (minutes < 10) _resultWorkouts.Minutes = $"0{minutes}";

            if (seconds < 10) _resultWorkouts.Seconds = $"0{seconds}";

            _resultWorkouts.Fascination = ResultFascination;
            _resultWorkouts.Load = ResultLoad;
            _resultWorkouts.WorkoutId = WorkoutId;
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
