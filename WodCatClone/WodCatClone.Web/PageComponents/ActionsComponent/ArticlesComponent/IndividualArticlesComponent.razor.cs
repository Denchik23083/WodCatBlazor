using System.Threading.Tasks;
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

        public string Url = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Value = 0;
            Url = $"articles/{Article.Id}";
            if (Article.ArticleEmblemId is not null)
            {
                Image = await ArticlesService.GetImage(Article.ArticleEmblemId);
            }
            if (Article.Type is not null)
            {
                ArticleType = Article.Type.Split(",");
            }
        }
        protected override async Task OnParametersSetAsync()
        {
            Value = 0;
            Url = $"articles/{Article.Id}";
            if (Article.ArticleEmblemId is not null)
            {
                Image = await ArticlesService.GetImage(Article.ArticleEmblemId);
            }
            if (Article.Type is not null)
            {
                ArticleType = Article.Type.Split(",");
            }
        }
    }
}
