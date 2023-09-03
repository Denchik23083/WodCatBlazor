using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.MorePage
{
    public partial class DeveloperPage
    {
        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUser();
        }
    }
}
