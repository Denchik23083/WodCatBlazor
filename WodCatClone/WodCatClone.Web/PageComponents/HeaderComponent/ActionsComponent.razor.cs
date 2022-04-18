using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ActionsComponent
    {
        [Inject] private NavigationManager _manager { get; set; }

        public int value = 0;

        public List<SelectedLink> Actions = new()
        {
            new() { Content = "ТРЕНИРОВКИ", Link = "/workouts" },
            new() { Content = "УПРАЖНЕНИЯ", Link = "/exercises" },
            new() { Content = "ЗАЛЫ", Link = "/gymboxs" },
            new() { Content = "РЕЙТИНГИ", Link = " /ratings" },
            new() { Content = "СТАТЬИ", Link = "/articles" }
        };

        public void Home() => _manager.NavigateTo("/");
    }
}
