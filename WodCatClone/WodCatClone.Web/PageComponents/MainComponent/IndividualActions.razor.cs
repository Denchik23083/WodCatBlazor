using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.PageComponents.MainComponent
{
    public partial class IndividualActions
    {
        [Inject] public IWorkoutsService WorkoutsService { get; set; }

        [Inject] public IExercisesService ExercisesService { get; set; }

        [Inject] public IHallsService HallsService { get; set; }
        
        [Inject] public IUserService UserService { get; set; }
        
        [Inject] public IArticlesService ArticlesService { get; set; }

        [Parameter] public Workouts Workout { get; set; }

        [Parameter] public Exercises Exercise { get; set; }

        [Parameter] public Halls Hall { get; set; }

        [Parameter] public User User { get; set; }

        [Parameter] public Articles Article { get; set; }

        public string WorkoutImage { get; set; }
        
        public string ExerciseImage { get; set; }
        
        public string HallImage { get; set; }

        public string UserImage { get; set; }

        public string ArticleImage { get; set; }

        protected override void OnInitialized()
        {
            if (Workout is not null)
            {
                WorkoutImage = WorkoutsService.GetImage(Workout.EmblemHallId);
            }
            if (Exercise is not null)
            {
                ExerciseImage = ExercisesService.GetExercise(Exercise.Id).Image;
            }
            if (Hall is not null)
            {
                HallImage = HallsService.GetImage(Hall.EmblemHallId);
            }
            if (User is not null && User.GenderId is not null)
            {
                UserImage = UserService.GetGender(User.GenderId).Image;
            }
            if (Article is not null)
            {
                ArticleImage = ArticlesService.GetImage(Article.ArticlesEmblemId);
            }
        }
    }
}
