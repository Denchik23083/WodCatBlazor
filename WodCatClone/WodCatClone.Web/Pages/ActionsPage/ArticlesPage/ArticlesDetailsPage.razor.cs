using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class ArticlesDetailsPage
    {
        [Parameter] public int ArticleId { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        public Articles Article { get; set; }

        public string Image { get; set; }

        protected override void OnInitialized()
        {
            Article = ArticlesService.GetArticle(ArticleId);
            Image = ArticlesService.GetImage(Article.ArticlesEmblemId);
        }
    }
}
