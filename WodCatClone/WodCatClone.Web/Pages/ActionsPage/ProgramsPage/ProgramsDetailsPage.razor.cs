using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ProgramsPage
{
    public partial class ProgramsDetailsPage
    {
        [Parameter] public int ProgramId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IProgramsService ProgramsService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        public Programs Program { get; set; }

        public bool IsLoginUser { get; set; }

        public bool DisplayWorkouts { get; set; } = true;

        public bool DisplayUsers { get; set; }

        public IEnumerable<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public IEnumerable<User> Users { get; set; }

        protected override void OnInitialized()
        {
            Program = ProgramsService.GetProgram(ProgramId);
            IsLoginUser = UserService.IsLoginUser();
            ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);
            Users = UserService.GetAllUsers();
        }

        public void BeginProgram()
        {
            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void Workout()
        {
            DisplayWorkouts = true;
            DisplayUsers = false;
        }

        public void User()
        {
            DisplayWorkouts = false;
            DisplayUsers = true;
        }
    }
}
