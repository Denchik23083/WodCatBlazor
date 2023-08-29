using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;
using WodCatClone.Logic.CallBackService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.MorePage
{
    public partial class DeveloperPage
    {
        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
        }
    }
}
