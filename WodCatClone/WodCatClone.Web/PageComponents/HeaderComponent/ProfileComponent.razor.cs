using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ProfileComponent
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }

        public string Image { get; set; }

        protected override void OnInitialized()
        {
            IsLoginUser = UserService.IsLoginUser();
            User = UserService.GetUser();

            if (User is not null && User.GenderId is not null)
            {
                Image = UserService.GetGender(User.GenderId).Image;
            }
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

        public List<SelectedLink> SelectedMore = new()
        {
            new() { Content = "Callback", Link = "/callback" },
            new() { Content = "Developer", Link = "/developer" },
        };
    }
}
