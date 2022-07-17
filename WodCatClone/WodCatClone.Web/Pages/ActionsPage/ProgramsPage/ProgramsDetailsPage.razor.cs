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

        public User User { get; set; }

        public bool IsLoginUser { get; set; }

        public bool DisplayWorkouts { get; set; } = true;

        public bool DisplayUsers { get; set; }

        public IEnumerable<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public IEnumerable<User> Users { get; set; }

        protected override void OnInitialized()
        {
            Program = ProgramsService.GetProgram(ProgramId);
            if (Program is null)
            {
                NavigationManager.NavigateTo("/programs");
            }
            else
            {
                IsLoginUser = UserService.IsLoginUser();
                ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);
                Users = ProgramsService.GetAllProgramsUsers(ProgramId);
                User = UserService.GetUser();
            }
        }

        public void BeginProgram()
        {
            var result = ProgramsService.BeginProgram(ProgramId, User);

            if (result)
            {
                NavigationManager.NavigateTo($"/programs/{ProgramId}");
            }
        }

        public void StopProgram()
        {
            var result = ProgramsService.StopProgram(ProgramId, User);

            if (result)
            {
                NavigationManager.NavigateTo($"/programs/{ProgramId}");
            }
        }

        public void DisplayWorkout()
        {
            DisplayWorkouts = true;
            DisplayUsers = false;
        }

        public void DisplayUser()
        {
            DisplayWorkouts = false;
            DisplayUsers = true;
        }
    }
}
