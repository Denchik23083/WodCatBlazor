using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class ProfilePage
    {
        [Parameter] public string NickName { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public User User { get; set; }

        public User UserEnter { get; set; }

        public bool IsLoginUser { get; set; }

        public bool IsEnterUser { get; set; }

        public string Image { get; set; }

        public Halls Hall { get; set; }

        public Programs Program { get; set; }

        public string HallEmblem { get; set; }

        public string ProgramEmblem { get; set; }

        public int Age { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser(NickName);

            if (User is not null)
            {
                Age = (DateTime.Today - User.Birthday).Days / 365;

                UserEnter = await UserService.GetUser();

                IsLoginUser = UserService.IsLoginUser();
                
                Image = UserService.GetGender(User.GenderId).Image;

                if (User.HallId is not null)
                {
                    Hall = HallsService.GetHall(User.HallId);
                    HallEmblem = HallsService.GetImage(Hall.EmblemHallId);
                }

                if (User.ProgramId is not null)
                {
                    Program = ProgramsService.GetProgram(User.ProgramId);
                    ProgramEmblem = ProgramsService.GetImage(Program.ProgramsEmblemId);
                }

                if (UserEnter is not null)
                {
                    if (User.NickName == UserEnter.NickName)
                    {
                        IsEnterUser = true;
                    }
                }
            }
            else
            {
                NavigationManager.NavigateTo("/");
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/profile/{NickName}/edit");
    }
}
