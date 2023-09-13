using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class AddArticlePage
    {
        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        public User? User { get; set; } = new();

        public bool IsLoginUser { get; set; }

        public IEnumerable<ArticleEmblem> ArticleEmblem { get; set; } = new List<ArticleEmblem>();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUserAsync();

            IsLoginUser = await UserService.IsLoginUserAsync();

            ArticleEmblem = await ArticlesService.GetAllArticleEmblemAsync();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void BackToArticlesList() => NavigationManager.NavigateTo("/articles");
    }
}
