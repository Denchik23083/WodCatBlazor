using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class IndividualRatingsComponent
    {
        [Parameter] public User User { get; set; } = new();

        [Parameter] public int Position { get; set; }

        public string? Image { get; set; }

        public string? GenderImage { get; set; }

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
            if (User.Halls is not null)
            {
                Image = User.Halls.EmblemHall!.Image;
            }

            GenderImage = User.Gender!.Image;
        }
    }
}
