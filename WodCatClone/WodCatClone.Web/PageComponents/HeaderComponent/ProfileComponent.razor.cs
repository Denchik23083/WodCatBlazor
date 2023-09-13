using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ProfileComponent
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Parameter] public User? User { get; set; } = new();

        public bool IsLoginUser { get; set; }

        public string? Image { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await FillOverrideFunctions();
        }

        protected override async Task OnParametersSetAsync()
        {
            await FillOverrideFunctions();
        }

        private async Task FillOverrideFunctions()
        {
            IsLoginUser = await UserService.IsLoginUserAsync();
            if (User?.Gender is not null)
            {
                Image = User.Gender.Image!;
            }
        }

        public void Auth() => NavigationManager.NavigateTo("/login");

        public List<SelectedLink> SelectProfile = new()
        {
            new() { Content = "Мой профиль", Link = "/profile" },
            new() { Content = "Редактирование", Link = "/edit" },
            new() { Content = "Выйти", Link = "/logout" },
        };

        string? _link = string.Empty;

        private void Route(ChangeEventArgs currentItem)
        {
            _link = currentItem.Value?.ToString();

            if (_link == "/profile")
            {
                _link += $"/{User!.NickName}";
            }
            if (_link == "/edit")
            {
                _link = $"/profile/{User!.NickName}/edit";
            }

            NavigationManager.NavigateTo($"{_link}");
        }

        public List<SelectedLink> SelectedMore = new()
        {
            new() { Content = "Callback", Link = "/callback" },
            new() { Content = "Developer", Link = "/developer" },
        };
    }
}
