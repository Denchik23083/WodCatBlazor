using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Web.Helpers;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class AddEditArticleComponent
    {
        [Inject] public IArticlesService ArticlesService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        [Parameter] public bool Edit { get; set; }

        [Parameter] public bool Add { get; set; }

        [Parameter] public int ArticleId { get; set; }

        public IEnumerable<ArticleEmblem> ArticleEmblem { get; set; }

        public Articles Article = new();

        public bool IsDisplaySubmitButton { get; set; } = false;

        public bool IsImage { get; set; } = false;

        public bool IsShow { get; set; } = false;

        public string Image = "None";

        public int Value { get; set; }

        public List<string> SelectedType = new();

        public List<ArticleTypes> ArticleTypes = new()
        {
            new() { Content = "Кроссфит", Value = "Кроссфит" },
            new() { Content = "Тренировки", Value = "Тренировки" },
            new() { Content = "Статьи", Value = "Статьи" },
            new() { Content = "Лёгкая атлетика", Value = "Лёгкая атлетика" },
            new() { Content = "Бодибилдинг", Value = "Бодибилдинг" },
            new() { Content = "Бокс", Value = "Бокс" },
            new() { Content = "Фитнесс", Value = "Фитнесс" },
            new() { Content = "Гиревой спорт", Value = "Гиревой спорт" },
            new() { Content = "Тяжелая атлетика", Value = "Тяжелая атлетика" },
        };

        protected override void OnInitialized()
        {
            ArticleEmblem = ArticlesService.GetAllArticleEmblem();
        }

        public void AddArticleType(string selected)
        {
            SelectedType.Add(selected);

            var item = ArticleTypes.FirstOrDefault(b => b.Value == selected);

            ArticleTypes.Remove(item);
        }

        public void Submit()
        {
            foreach (var item in SelectedType)
            {
                if (Value == 0)
                {
                    Article.Type = $"{item}";
                    Value++;
                }
                else
                {
                    Article.Type += $",{item}";
                }
            }

            if (Add)
            {
                var result = ArticlesService.AddArticle(Article);

                NavigationManager.NavigateTo(result ? "/articles" : "/articles/add");
            }

            if (Edit)
            {
                var result = ArticlesService.EditArticle(Article, ArticleId);

                NavigationManager.NavigateTo(result ? $"/articles/{ArticleId}" : $"/articles/{ArticleId}/edit");
            }
        }

        public void RemoveSelectedType(string item)
        {
            SelectedType.Remove(item);

            ArticleTypes.Add(new() { Content = item, Value = item });
        }

        public void SelectedImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            var articleEmblem = ArticleEmblem.FirstOrDefault(b => b.Image == selected);

            Image = selected;

            if (articleEmblem is not null)
            {
                Article.ArticleEmblemId = articleEmblem.Id;
                IsImage = true;
            }

            if (IsImage)
            {
                IsDisplaySubmitButton = true;
            }
        }
    }
}
