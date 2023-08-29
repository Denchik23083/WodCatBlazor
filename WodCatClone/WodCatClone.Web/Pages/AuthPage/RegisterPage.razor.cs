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
        [Inject] public IAuthService AuthService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        public IEnumerable<Gender> Genders { get; set; } = new List<Gender>();

        public RegisterModel RegisterModel = new();

        public User? User { get; set; } = new();

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

        protected override async Task OnInitializedAsync()
        {
            Genders = await UserService.GetGenders();
            User = UserService.GetUser();
        }

        public async Task Register()
        {
            if (RegisterModel.Password != RegisterModel.ConfirmPassword) return;

            var mappedUser = Mapper.Map<User>(RegisterModel);

            var result = await AuthService.Register(mappedUser);

            if (result)
            {
                NavigationManager.NavigateTo("/login");
            }
        }
    }
}
