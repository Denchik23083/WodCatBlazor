using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditProfileComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public IGenderService GenderService { get; set; }

        public string Image { get; set; }

        public bool IsTown { get; set; } = false;

        public bool IsDisplaySubmitButton { get; set; } = false;

        public bool Man { get; set; }
        
        public bool Woman { get; set; }

        public User EditUser = new();

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
            new() { Content = "Львов", Filter = "Львов" },
        };

        protected override void OnInitialized()
        {
            Image = GenderService.GetGenderImage(User.GenderId);

            var gender = GenderService.GetGender(User.GenderId);

            if (gender == "Мужской")
            {
                Man = true;
                Woman = false;
            }
            if (gender == "Женский")
            {
                Man = false;
                Woman = true;
            }
        }

        public void Submit()
        {

        }

        public void TownValue(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            if (selected == "None")
            {
                IsDisplaySubmitButton = false;
                IsTown = false;
            }
            else
            {
                IsTown = true;
                User.Town = selected;
            }

            if (IsTown)
            {
                IsDisplaySubmitButton = true;
            }
        }
    }
}
