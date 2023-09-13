using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class ConfirmRemoveArticle
    {
        [Parameter] public EventCallback OnShow { get; set; }

        [Parameter] public EventCallback OnCancel { get; set; }

        [Parameter] public int ArticleId { get; set; }

        [Parameter] public Articles? Article { get; set; } = new();

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public bool DisplayRemoveArticle { get; set; }

        public void Show() => DisplayRemoveArticle = true;

        public void Hide() => DisplayRemoveArticle = false;

        public async Task Remove()
        {
            var result = await ArticlesService.RemoveArticleAsync(ArticleId);

            NavigationManager.NavigateTo(result ? "/articles" : $"/articles/{ArticleId}");
        }
    }
}
