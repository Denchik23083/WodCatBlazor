using System.Collections.Generic;
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

        public bool IsLoginUser { get; set; }

        public User? User { get; set; } = new() { Gender = new Gender {Image = ""} };

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
            IsLoginUser = UserService.IsLoginUser();
            User = await UserService.GetUser();
        }

        public void Auth() => NavigationManager.NavigateTo("/login");

        public List<SelectedLink> SelectProfile = new()
        {
            new() { Content = "Мой профиль", Link = "/profile" },
            new() { Content = "Редактирование", Link = "/edit" },
            new() { Content = "Выйти", Link = "/logout" },
        };

        string? _link = string.Empty;

        void Route(ChangeEventArgs currentItem)
        {
            _link = currentItem.Value?.ToString();

            if (_link == "/profile")
            {
                _link += $"/{User.NickName}";
            }
            if (_link == "/edit")
            {
                _link = $"/profile/{User.NickName}/edit";
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
