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

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public User EditUser { get; set; }

        public Register AuthUser { get; set; }

        public string Image { get; set; }

        public bool IsTown { get; set; } = false;

        public bool IsDisplaySubmitButton { get; set; } = false;

        public bool Man { get; set; }
        
        public bool Woman { get; set; }

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
            AuthUser = Map(User);

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

        public void Auth()
        {
            if (AuthUser.Password == AuthUser.ConfirmPassword)
            {
                var result = UserService.UpdateAuth(Map(AuthUser), User.Id);

                if (result)
                {
                    var user = UserService.GetUser();

                    NavigationManager.NavigateTo($"/profile/{user.NickName}");
                }
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

        private Register Map(User model)
        {
            return new Register
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }

        private User Map(Register model)
        {
            return new User
            {
                NickName = model.NickName,
                Email = model.Email,
                Password = model.Password
            };
        }
    }
}
