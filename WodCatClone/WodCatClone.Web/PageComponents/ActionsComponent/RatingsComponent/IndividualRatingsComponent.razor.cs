using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.RatingsComponent
{
    public partial class IndividualRatingsComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Parameter] public int Position { get; set; }

        public string Image { get; set; }

        public string GenderImage { get; set; }

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
            var hall = HallsService.GetHall(User.HallId);
            if (hall is not null)
            {
                Image = HallsService.GetImage(hall.EmblemHallId);
            }
            if (User.GenderId is not null)
            {
                GenderImage = UserService.GetGender(User.GenderId).Image;
            }
        }
    }
}
