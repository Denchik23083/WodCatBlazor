using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.HeaderComponent
{
    public partial class ActionsComponent
    {
        [Inject] private NavigationManager NavigationManager { get; set; }

        public int Value = 0;

        public List<SelectedLink> Actions = new()
        {
            new() { Content = "ПРОГРАММЫ", Link = "/programs" },
            new() { Content = "ТРЕНИРОВКИ", Link = "/workouts" },
            new() { Content = "УПРАЖНЕНИЯ", Link = "/exercises" },
            new() { Content = "МЕРОПРИЯТИЯ", Link = "/events" },
            new() { Content = "ЗАЛЫ", Link = "/gymboxs" },
            new() { Content = "РЕЙТИНГИ", Link = " /ratings" },
            new() { Content = "СТАТЬИ", Link = "/articles" }
        };

        public void Home()
        {
            Value = 0;
            NavigationManager.NavigateTo("/");
        }
    }
}
