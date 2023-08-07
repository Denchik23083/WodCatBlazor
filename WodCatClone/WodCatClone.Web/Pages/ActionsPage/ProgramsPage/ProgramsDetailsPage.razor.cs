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

        public ProgramsWorkouts ProgramWorkout { get; set; }
        
        public User User { get; set; }

        public bool IsLoginUser { get; set; }

        public bool DisplayWorkouts { get; set; } = true;

        public bool DisplayDayWorkouts { get; set; }

        public bool DisplayUsers { get; set; }

        public int Day { get; set; }

        public IEnumerable<ProgramsWorkouts> ProgramsWorkouts { get; set; }

        public IEnumerable<User> Users { get; set; }

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            FillOverrideFunctions();
        }

        private async Task FillOverrideFunctions()
        {
            Program = ProgramsService.GetProgram(ProgramId);
            IsLoginUser = UserService.IsLoginUser();
            User = await UserService.GetUser();
            Users = ProgramsService.GetAllProgramsUsers(ProgramId);
            ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);

            if (Program is null)
            {
                NavigationManager.NavigateTo("/programs");
            }
            else
            {
                if (User is not null)
                {
                    ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);
                    if (User.ProgramId == ProgramId)
                    {
                        var programTimeUser = ProgramsService.GetProgramTimeUser(ProgramId, User);
                        Day = (DateTime.Now - programTimeUser.BeginProgramDate).Days;
                        ProgramWorkout = ProgramsService
                            .GetAllProgramsWorkouts(ProgramId)
                            .ElementAtOrDefault(Day);
                    }
                    else
                    {
                        ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);
                    }
                }
                else
                {
                    ProgramsWorkouts = ProgramsService.GetAllProgramsWorkouts(ProgramId);
                }
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
            var result = ProgramsService.StopProgram(ProgramId, User, false);

            if (result)
            {
                NavigationManager.NavigateTo($"/programs/{ProgramId}");
            }
        }

        public void DisplayWorkout()
        {
            DisplayWorkouts = true;
            DisplayDayWorkouts = false;
            DisplayUsers = false;
        }

        public void DisplayDayWorkout()
        {
            DisplayWorkouts = false;
            DisplayDayWorkouts = true;
            DisplayUsers = false;
        }

        public void DisplayUser()
        {
            DisplayWorkouts = false;
            DisplayDayWorkouts = false;
            DisplayUsers = true;
        }
    }
}
