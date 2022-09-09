using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Utilities;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService AuthService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        public Register MainRegister = new();
        
        public bool IsTown { get; set; }

        public bool Man { get; set; } = true;

        public bool Woman { get; set; } = false;

        public bool IsDisplaySubmitButton { get; set; } = false;

        public string Gender { get; set; }

        public List<AuthTown> Town = new()
        {
            new() { Content = "Херсон", Value = "Херсон" },
            new() { Content = "Киев", Value = "Киев" },
            new() { Content = "Харьков", Value = "Харьков" },
            new() { Content = "Николаев", Value = "Николаев" },
            new() { Content = "Одесса", Value = "Одесса" },
            new() { Content = "Черновцы", Value = "Черновцы" },
            new() { Content = "Днепр", Value = "Днепр" },
            new() { Content = "Хмельницкий", Value = "Хмельницкий" },
            new() { Content = "Кривой Рог", Value = "Кривой Рог" },
            new() { Content = "Запорожье", Value = "Запорожье" },
            new() { Content = "Львов", Value = "Львов" },
        };

        public void Register()
        {
            if (MainRegister.Password == MainRegister.ConfirmPassword)
            {
                if (Man)
                {
                    Gender = "Мужской";
                }
                if (Woman)
                {
                    Gender = "Женский";
                }

                var gender = UserService.GetGender(Gender);
                MainRegister.GenderId = gender.Id;

                var result = AuthService.Register(MainRegister);
                if (result)
                {
                    NavigationManager.NavigateTo("/login");
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
                MainRegister.Town = selected;
            }

            if (IsTown)
            {
                IsDisplaySubmitButton = true;
            }
        }
    }
}
