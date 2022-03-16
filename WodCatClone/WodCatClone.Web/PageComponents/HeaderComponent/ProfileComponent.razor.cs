using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ProfileComponent
    {
        [Inject] private NavigationManager _manager { get; set; }
        [Inject] IUserService _service { get; set; }

        public bool IsLoginUser = false;

        protected override void OnInitialized()
        {
            IsLoginUser = _service.IsLoginUser();
        }

        public void Auth()
        {
            _manager.NavigateTo("/login");
        }

        [Inject] public IUserService Service { get; set; }

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
            _manager.NavigateTo($"{_link}");
        }

        public List<SelectedLink> SelectedMore = new()
        {
            new() { Content = "RM-Calc", Link = "/calc" },
            new() { Content = "Обратная связь", Link = "/callback" },
            new() { Content = "Developer", Link = "developer" },
            new() { Content = "Dark / Light theme", Link = "/ua" },
        };
    }
}
