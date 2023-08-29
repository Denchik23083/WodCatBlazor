using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class ArticlesPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IArticlesService ArticlesService { get; set; } = null!; 

        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        public IEnumerable<Articles> Articles { get; set; } = new List<Articles>();

        public bool IsLoginUser { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser();
            Articles = await ArticlesService.GetAllArticles();
            IsLoginUser = UserService.IsLoginUser();
        }

        public void Add() => NavigationManager.NavigateTo("/articles/add");
    }
}
