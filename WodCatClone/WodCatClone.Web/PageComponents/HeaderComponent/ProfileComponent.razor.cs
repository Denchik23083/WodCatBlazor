using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ProfileComponent
    {
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Inject] IUserService UserService { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            IsLoginUser = UserService.IsLoginUser();
            User = UserService.GetUser();
        }

        public void Auth() => NavigationManager.NavigateTo("/login");

        public List<SelectedLink> SelectProfile = new()
        {
            new() { Content = "Мой профиль", Link = "/profile" },
            new() { Content = "Редактирование", Link = "/edit" },
            new() { Content = "Выйти", Link = "/logout" },
        };

        string _link = string.Empty;

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
    }
}
