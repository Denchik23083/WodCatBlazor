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

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IProgramsService ProgramsService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        public Programs? Program { get; set; } = new();

        public ProgramsWorkouts? ProgramWorkout { get; set; } = new();

        public User? User { get; set; } = new();

        public bool IsLoginUser { get; set; }

        public bool DisplayWorkouts { get; set; } = true;

        public bool DisplayDayWorkouts { get; set; }

        public bool DisplayUsers { get; set; }

        public int Day { get; set; }

        public IEnumerable<ProgramsWorkouts> ProgramsWorkouts { get; set; } = new List<ProgramsWorkouts>();

        public IEnumerable<User> Users { get; set; } = new List<User>();

        protected override async Task OnInitializedAsync()
        {
            await FillOverrideFunctions();
        }

        protected override async Task OnParametersSetAsync()
        {
            await FillOverrideFunctions();
        }

        private async Task FillOverrideFunctions()
        {
            User = await UserService.GetUser();
            IsLoginUser = await UserService.IsLoginUser();

            Program = await ProgramsService.GetProgram(ProgramId);

            if (Program is null)
            {
                NavigationManager.NavigateTo("/programs");
            }
            else
            {                
                Users = Program.Users!;
                ProgramsWorkouts = Program.ProgramsWorkouts!;

                if (User is not null)
                {
                    ProgramsWorkouts = Program.ProgramsWorkouts!;
                    if (User.ProgramId == ProgramId)
                    {
                        var programTimeUser = Program!.ProgramTimeUsers!.FirstOrDefault(b => b.ProgramsId == ProgramId && b.UserId == User!.Id);
                        if (programTimeUser is not null)
                        {
                            Day = (DateTime.Now - programTimeUser.BeginProgramDate).Days;
                            ProgramWorkout = Program!.ProgramsWorkouts!.ElementAtOrDefault(Day)!;
                        }
                    }
                    else
                    {
                        ProgramsWorkouts = Program.ProgramsWorkouts!;
                    }
                }
                else
                {
                    ProgramsWorkouts = Program.ProgramsWorkouts!;
                }
            }
        }

        public async Task BeginProgram()
        {
            var result = await ProgramsService.BeginProgram(ProgramId, User!);

            if (result)
            {
                NavigationManager.NavigateTo($"/programs/{ProgramId}");
            }
        }

        public async Task StopProgram()
        {
            var result = await ProgramsService.StopProgram(ProgramId, User!, false);

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
