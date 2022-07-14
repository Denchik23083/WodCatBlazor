using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ProfileComponent
{
    public partial class EditProfileComponent
    {
        [Parameter] public User User { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        public User EditUser { get; set; }

        public Register AuthUser { get; set; }

        public Halls UserHall { get; set; }

        public Programs UserProgram { get; set; }

        public IEnumerable<Halls> Halls { get; set; }

        public IEnumerable<Programs> Programs { get; set; }

        public string HallImage { get; set; }

        public string ProgramImage { get; set; }

        public string Image { get; set; }

        public bool Man { get; set; }
        
        public bool Woman { get; set; }

        public bool IsShowHall { get; set; } = false;

        public bool IsShowProgram { get; set; } = false;

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
            new() { Content = "Запорожье", Filter = "Запорожье" },
            new() { Content = "Львов", Filter = "Львов" },
        };

        protected override void OnInitialized()
        {
            UserHall = HallsService.GetHall(User.HallId);
            Halls = HallsService.GetAllHalls();
            if (UserHall is not null)
            {
                HallImage = HallsService.GetImage(UserHall.EmblemHallId);
            }

            UserProgram = ProgramsService.GetProgram(User.ProgramId);
            Programs = ProgramsService.GetAllPrograms();
            if (UserProgram is not null)
            {
                ProgramImage = ProgramsService.GetImage(UserProgram.ProgramsEmblemId);
            }

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

        protected override void OnParametersSet()
        {
            UserHall = HallsService.GetHall(User.HallId);
            Halls = HallsService.GetAllHalls();
            if (UserHall is not null)
            {
                HallImage = HallsService.GetImage(UserHall.EmblemHallId);
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

            User.Town = selected;
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
