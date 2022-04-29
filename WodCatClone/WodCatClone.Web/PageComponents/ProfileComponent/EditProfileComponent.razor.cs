using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditProfileComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public User EditUser { get; set; }

        public string Image { get; set; }

        public bool IsTown { get; set; } = false;

        public bool IsDisplaySubmitButton { get; set; } = false;

        public bool Man { get; set; }
        
        public bool Woman { get; set; }

        public IEnumerable<Halls> Halls { get; set; }

        public Halls UserHall { get; set; }

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
            EditUser = User;
            if (User.GenderId is not null)
            {
                Image = UserService.GetGender(User.GenderId).Image;
            }

            var gender = UserService.GetGender(User.GenderId);

            if (gender.Name == "Мужской")
            {
                Man = true;
                Woman = false;
            }
            if (gender.Name == "Женский")
            {
                Man = false;
                Woman = true;
            }
        }

        public void Submit()
        {
            var gender = UserService.GetGender(User.GenderId);

            if (Man && !Woman)
            {
                gender.Name = "Мужской";
            }

            if (Woman && !Man)
            {
                gender.Name = "Женский";
            }

            var result = UserService.Update(EditUser, User.Id, gender);

            if (result)
            {
                NavigationManager.NavigateTo($"/profile/{User.NickName}");
            }
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
