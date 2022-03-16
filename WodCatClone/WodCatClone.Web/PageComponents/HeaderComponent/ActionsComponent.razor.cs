using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ActionsComponent
    {
        [Inject] private NavigationManager _manager { get; set; }

        public List<SelectedLink> Actions = new()
        {
            new() { Content = "ПРОГРАММЫ", Link = "/programs" },
            new() { Content = "ТРЕНИРОВКИ", Link = "/workouts" },
            new() { Content = "УПРАЖНЕНИЯ", Link = "/exercises" },
            new() { Content = "МЕРОПРИЯТИЯ", Link = "/events" },
            new() { Content = "ЗАЛЫ", Link = "/gymbox" },
            new() { Content = "СТАТЬИ", Link = "/articles" }
        };

        public void Home()
        {
            _manager.NavigateTo("/");
        }
    }
}
