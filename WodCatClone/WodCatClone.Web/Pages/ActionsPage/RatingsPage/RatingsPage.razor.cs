using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.RatingsPage
{
    public partial class RatingsPage
    {
        [Inject] public IUserService UserService { get; set; } = null!;

        public IEnumerable<User> Users { get; set; } = new List<User>();

        protected override async Task OnInitializedAsync()
        {
            Users = await UserService.GetAllUsers();
        }
    }
}
