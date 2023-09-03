using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.UserService;
using WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class ArticlesDetailsPage
    {
        [Parameter] public int ArticleId { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        [Inject] public IUserService UserService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        public Articles? Article { get; set; } = new();

        public string? Image { get; set; }

        public User? User { get; set; } = new();

        public ConfirmRemoveArticle? ConfirmRemoveArticle { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            User = await UserService.GetUser();

            Article = await ArticlesService.GetArticle(ArticleId);
            if (Article is null)
            {
                NavigationManager.NavigateTo("/articles");
            }
            else
            {
                Image = Article.ArticleEmblem!.Image;
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/articles/{ArticleId}/edit");

        public void OnShow() => ConfirmRemoveArticle!.Show();

        public void OnCancel() => ConfirmRemoveArticle!.Hide();
    }
}
