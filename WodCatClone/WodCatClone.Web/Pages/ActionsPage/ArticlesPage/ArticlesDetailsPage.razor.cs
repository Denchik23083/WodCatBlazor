using System.Threading.Tasks;
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

        [Inject] public IArticlesService ArticlesService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Articles Article { get; set; }

        public string Image { get; set; }

        public User User { get; set; }

        public ConfirmRemoveArticle ConfirmRemoveArticle { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Article = await ArticlesService.GetArticle(ArticleId);
            if (Article is null)
            {
                NavigationManager.NavigateTo("/articles");
            }
            else
            {
                Image = await ArticlesService.GetImage(Article.ArticleEmblemId);
                User = UserService.GetUser();
            }
        }

        public void Edit() => NavigationManager.NavigateTo($"/articles/{ArticleId}/edit");

        public void OnShow() => ConfirmRemoveArticle.Show();

        public void OnCancel() => ConfirmRemoveArticle.Hide();
    }
}
