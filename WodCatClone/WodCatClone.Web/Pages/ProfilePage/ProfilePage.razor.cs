using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ProfilePage
{
    public partial class ProfilePage
    {
        [Parameter] public string NickName { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public User? User { get; set; } = new();

        public User? UserEnter { get; set; } = new();

        public bool IsLoginUser { get; set; }

        public bool IsEnterUser { get; set; }

        public string? Image { get; set; }

        public Halls? Hall { get; set; } = new();

        public Programs? Program { get; set; } = new();

        public string? HallEmblem { get; set; }

        public string? ProgramEmblem { get; set; }

        public int Age { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserEnter = await UserService.GetUser();
            User = await UserService.GetUser(NickName);

            if (User is not null)
            {
                Age = (DateTime.Today - User.Birthday).Days / 365;

                IsLoginUser = await UserService.IsLoginUser();

                Image = User.Gender!.Image!;

                Hall = User.Halls!;
                if (User.Halls is not null)
                {
                    HallEmblem = User.Halls!.EmblemHall!.Image!;
                }

                Program = User.Programs!;

                if (User.Programs is not null)
                {
                    ProgramEmblem = User.Programs!.ProgramEmblem!.Image!;
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
