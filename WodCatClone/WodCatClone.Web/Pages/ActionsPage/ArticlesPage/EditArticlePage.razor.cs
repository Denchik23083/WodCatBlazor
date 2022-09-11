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

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        public bool IsLoginUser { get; set; }

        public User User { get; set; }

        public Articles Article { get; set; }

        protected override void OnInitialized()
        {
            Article = ArticlesService.GetArticle(ArticleId);
            if (Article is null)
            {
                NavigationManager.NavigateTo("/articles");
            }
            else
            {
                IsLoginUser = UserService.IsLoginUser();
                User = UserService.GetUser();

                if (!IsLoginUser)
                {
                    NavigationManager.NavigateTo("/login");
                }

                if (User.Id != Article.UserId)
                {
                    NavigationManager.NavigateTo("/articles");
                }
            }
        }

        public void BackToArticle() => NavigationManager.NavigateTo($"/articles/{ArticleId}");
    }
}
