using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ExercisesComponent
{
    public partial class ExercisesInfo
    {
        [Inject] public IUserService _userService { get; set; }

        public bool IsDisplay { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            IsLoginUser = _userService.IsLoginUser();
        }
    }
}
