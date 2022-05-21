using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.UserService;

namespace WodCatClone.Web.Pages.ActionsPage.ArticlesPage
{
    public partial class ArticlesPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        [Inject] public IUserService UserService { get; set; }

        IEnumerable<Articles> Articles { get; set; }

        public bool IsLoginUser { get; set; }

        protected override void OnInitialized()
        {
            Articles = ArticlesService.GetAllArticles();

            IsLoginUser = UserService.IsLoginUser();
        }

        public void Add() => NavigationManager.NavigateTo("/articles/add");
    }
}
