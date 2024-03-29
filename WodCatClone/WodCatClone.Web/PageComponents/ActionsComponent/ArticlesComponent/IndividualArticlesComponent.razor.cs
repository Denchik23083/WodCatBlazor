﻿using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class IndividualArticlesComponent
    {
        [Parameter] public Articles Article { get; set; } = new();

        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        public string? Image { get; set; }

        public string[]? ArticleType { get; set; }

        public int Value { get; set; }

        public string Url = string.Empty;

        protected override void OnInitialized()
        {
            FillOverrideFunctions();
        }

        protected override void OnParametersSet()
        {
            FillOverrideFunctions();
        }

        private void FillOverrideFunctions()
        {
            Value = 0;
            Url = $"articles/{Article.Id}";

            Image = Article.ArticleEmblem!.Image;

            if (Article.Type is not null)
            {
                ArticleType = Article.Type.Split(",");
            }
        }
    }
}
