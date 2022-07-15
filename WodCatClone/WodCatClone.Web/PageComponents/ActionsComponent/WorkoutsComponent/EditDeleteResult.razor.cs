using System;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.WorkoutsComponent
{
    public partial class EditDeleteResult
    {
        [Parameter] public EventCallback OnDelete { get; set; }

        [Parameter] public EventCallback OnEdit { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public EventCallback OnCancelEdit { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public bool DisplayEditDeleteResult { get; set; }

        public bool DisplayEditResult { get; set; } = true;

        public ResultWorkouts EditResultWorkout = new();

        public void Show() => DisplayEditDeleteResult = true;

        public void Hide() => DisplayEditDeleteResult = false;

        public void EditHide() => DisplayEditResult = true;

        private bool _oneFascination, _twoFascination, _threeFascination, _fourFascination, _fiveFascination;
        private bool _oneLoad, _twoLoad, _threeLoad, _fourLoad, _fiveLoad;

        public int ResultFascination { get; set; }

        public int ResultLoad { get; set; }

        public User User { get; set; }

        public DateTime Time { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
        }

        public void FillData()
        {
            ResultFascinationStars();
            ResultLoadStars();

            EditResultWorkout.Time = new TimeSpan(Time.Hour, Time.Minute, Time.Second);

            EditResultWorkout.Comment ??= "";
            
            EditResultWorkout.Fascination = ResultFascination;
            EditResultWorkout.Load = ResultLoad;
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
