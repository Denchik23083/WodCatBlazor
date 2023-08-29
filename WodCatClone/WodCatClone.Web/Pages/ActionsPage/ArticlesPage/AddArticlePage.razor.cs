using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class AddArticlePage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IUserService UserService { get; set; } = null!;

        public User? User { get; set; } = new();

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            User = UserService.GetUser();

            IsLoginUser = UserService.IsLoginUser();

            if (!IsLoginUser)
            {
                NavigationManager.NavigateTo("/login");
            }
        }

        public void BackToArticlesList() => NavigationManager.NavigateTo("/articles");
    }
}
