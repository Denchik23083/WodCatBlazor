using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.HallsComponent
{
    public partial class HallsInfo
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
