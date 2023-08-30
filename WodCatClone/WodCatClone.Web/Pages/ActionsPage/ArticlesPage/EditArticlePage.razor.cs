using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class EditArticlePage
    {
        [Parameter] public int ArticleId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        public bool IsLoginUser { get; set; }

        public Articles? Article { get; set; } = new();

        public User? User { get; set; } = new();

        public IEnumerable<ArticleEmblem> ArticleEmblem { get; set; } = new List<ArticleEmblem>();

        protected override async Task OnInitializedAsync()
        {
            User = UserService.GetUser();
            IsLoginUser = UserService.IsLoginUser();

            Article = await ArticlesService.GetArticle(ArticleId);
            if (Article is null)
            {
                NavigationManager.NavigateTo("/articles");
            }
            else
            {
                if (!IsLoginUser)
                {
                    NavigationManager.NavigateTo("/login");
                }

                if (User?.Id != Article.UserId)
                {
                    NavigationManager.NavigateTo("/articles");
                }
            }

            ArticleEmblem = await ArticlesService.GetAllArticleEmblem();
        }

        public void BackToArticle() => NavigationManager.NavigateTo($"/articles/{ArticleId}");
    }
}
