using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.RatingsPage
{
    public partial class RatingsPage
    {
        [Inject] public IUserService UserService { get; set; }

        public IEnumerable<User> Users { get; set; }

        protected override void OnInitialized()
        {
            Users = UserService.GetAllUsers();
        }
    }
}
