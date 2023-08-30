using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ProgramsComponent
{
    public partial class IndividualProgramsUsersComponent
    {
        [Parameter] public User User { get; set; } = new();

        public string? Image { get; set; }

        public string? GenderImage { get; set; }

        protected override void OnInitialized()
        {
            var hall = User.Halls;

            if (hall is not null)
            {
                Image = hall.EmblemHall!.Image!;
            }

            GenderImage = User.Gender!.Image!;
        }
    }
}
