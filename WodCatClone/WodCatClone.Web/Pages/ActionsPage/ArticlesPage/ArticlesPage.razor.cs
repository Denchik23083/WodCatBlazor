using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class ArticlesPage
    {
        [Inject] public IArticlesService ArticlesService { get; set; }

        IEnumerable<Articles> Articles { get; set; }

        protected override void OnInitialized()
        {
            Articles = ArticlesService.GetAllArticles();
        }
    }
}
