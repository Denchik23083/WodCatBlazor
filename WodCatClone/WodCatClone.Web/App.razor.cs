using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web
{
    public partial class App
    {
        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        protected override void OnInitialized()
        {
            User = UserService.GetUser();
        }
    }
}
