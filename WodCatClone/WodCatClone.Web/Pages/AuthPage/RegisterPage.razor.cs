using AutoMapper;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Models;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.Pages.AuthPage
{
    public partial class RegisterPage
    {
        [Inject] private IAuthService AuthService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        public RegisterModel RegisterModel = new();

        public bool Man { get; set; } = true;

        public bool Woman { get; set; } = false;
        
        public string Gender { get; set; } = null!;

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

        public async Task Register()
        {
            if (RegisterModel.Password != RegisterModel.ConfirmPassword) return;

            if (Man)
            {
                Gender = "Мужской";
            }
            if (Woman)
            {
                Gender = "Женский";
            }

            var gender = UserService.GetGender(Gender);
            RegisterModel.GenderId = gender.Id;

            var mappedUser = Mapper.Map<User>(RegisterModel);

            var result = await AuthService.Register(mappedUser);

            if (result)
            {
                NavigationManager.NavigateTo("/login");
            }
        }
    }
}
