using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class IndividualProfileHallComponent
    {
        [Parameter] public Halls? Hall { get; set; } = new();
        
        [Parameter] public User User { get; set; } = new();

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public string? HallImage { get; set; }

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            if (Hall is not null)
            {
                HallImage = Hall.EmblemHall!.Image!;
            }
        }

        public async Task EditUserHall(int id)
        {
            var result = await UserService.EditUserHallAsync(User, id);

            if (result)
            {
                NavigationManager.NavigateTo($"/profile/{User.NickName}/edit", true);
            }
        }
    }
}
