using Microsoft.AspNetCore.Components;
using WodCatClone.Core;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditProfileComponent
    {
        [Parameter] public User? User { get; set; } = new();

        [Parameter] public IEnumerable<Halls> Halls { get; set; } = new List<Halls>();

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IHallsService HallsService { get; set; } = null!;

        public Halls? Hall { get; set; }

        public string? HallImage { get; set; }

        public string? Image { get; set; }

        public bool Man { get; set; }
        
        public bool Woman { get; set; }

        public bool IsShowHall { get; set; } = false;

        public bool IsDisplayProfile { get; set; } = true;

        public bool IsDisplayAuth { get; set; }

        public List<FilterHalls> Town = new()
        {
            new() { Content = "Херсон", Filter = "Херсон" },
            new() { Content = "Киев", Filter = "Киев" },
            new() { Content = "Харьков", Filter = "Харьков" },
            new() { Content = "Николаев", Filter = "Николаев" },
            new() { Content = "Одесса", Filter = "Одесса" },
            new() { Content = "Черновцы", Filter = "Черновцы" },
            new() { Content = "Днепр", Filter = "Днепр" },
            new() { Content = "Хмельницкий", Filter = "Хмельницкий" },
            new() { Content = "Кривой Рог", Filter = "Кривой Рог" },
            new() { Content = "Запорожье", Filter = "Запорожье" },
            new() { Content = "Львов", Filter = "Львов" },
        };

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
            if (User?.Gender is null) return;

            Image = User.Gender!.Image;
            if (User.Halls is not null)
            {
                Hall = User.Halls!;
                if (Hall is not null)
                {
                    HallImage = User.Halls!.EmblemHall!.Image;
                }
            }
            switch (User.Gender!.Type)
            {
                case GenderType.Male:
                    Man = true;
                    Woman = false;
                    break;
                case GenderType.Female:
                    Man = false;
                    Woman = true;
                    break;
            }
        }

        public void Submit()
        {
            if (Man && !Woman)
            {
                User!.Gender!.Type = GenderType.Male;
            }

            if (Woman && !Man)
            {
                User!.Gender!.Type = GenderType.Female;
            }

            var result = UserService.Update(User!, User!.Id);

            if (result)
            {
                NavigationManager.NavigateTo($"/profile/{User.NickName}");
            }
        }

        public void DisplayProfile()
        {
            IsDisplayProfile = true;
            IsDisplayAuth = false;
        }

        public void DisplayAuth()
        {
            IsDisplayProfile = false;
            IsDisplayAuth = true;
        }
    }
}
