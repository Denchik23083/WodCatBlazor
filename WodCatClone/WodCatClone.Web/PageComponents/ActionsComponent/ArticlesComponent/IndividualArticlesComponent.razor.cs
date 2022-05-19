using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class IndividualArticlesComponent
    {
        [Parameter] public Articles Article { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        public string Image { get; set; }

        public string[] ArticleType { get; set; }

        public int Value { get; set; }

        string _url = string.Empty;

        protected override void OnInitialized()
        {
            Value = 0;
            _url = $"articles/{Article.Id}";
            Image = ArticlesService.GetImage(Article.ArticlesEmblemId);
            ArticleType = Article.Type.Split(",");
        }
        protected override void OnParametersSet()
        {
            Value = 0;
            _url = $"articles/{Article.Id}";
            Image = ArticlesService.GetImage(Article.ArticlesEmblemId);
            ArticleType = Article.Type.Split(",");
        }
    }
}
