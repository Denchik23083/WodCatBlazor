using AutoMapper;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Web.Models;
using WodCatClone.Web.Utilities.Types;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class AddEditArticleComponent
    {
        [Inject] public IArticlesService ArticlesService { get; set; } = null!;

        [Inject] public NavigationManager NavigationManager { get; set; } = null!;

        [Inject] public IMapper Mapper { get; set; } = null!;

        [Parameter] public Articles? Article { get; set; } = new();

        [Parameter] public bool Edit { get; set; }

        [Parameter] public bool Add { get; set; }

        [Parameter] public int ArticleId { get; set; }

        [Parameter] public IEnumerable<ArticleEmblem> ArticleEmblem { get; set; } = new List<ArticleEmblem>();
        
        public ArticlesModel? UpdateArticle { get; set; } = new();

        public bool IsShow { get; set; } = false;

        public bool IsBadEmblem { get; set; }

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

        public List<ArticleRating> ArticleRating = new()
        {
            new() { Content = "0.5", Value = "0.5" },
            new() { Content = "1.0", Value = "1.0" },
            new() { Content = "1.5", Value = "1.5" },
            new() { Content = "2.0", Value = "2.0" },
            new() { Content = "2.5", Value = "2.5" },
            new() { Content = "3.0", Value = "3.0" },
            new() { Content = "3.5", Value = "3.5" },
            new() { Content = "4.0", Value = "4.0" },
            new() { Content = "4.5", Value = "4.5" },
            new() { Content = "5.0", Value = "5.0" },
            new() { Content = "5.5", Value = "5.5" },
            new() { Content = "6.0", Value = "6.0" },
            new() { Content = "6.5", Value = "6.5" },
            new() { Content = "7.0", Value = "7.0" },
            new() { Content = "7.5", Value = "7.5" },
            new() { Content = "8.0", Value = "8.0" },
            new() { Content = "8.5", Value = "8.5" },
            new() { Content = "9.0", Value = "9.0" },
            new() { Content = "9.5", Value = "9.5" },
            new() { Content = "10.0", Value = "10.0" }
        };

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
            if (ArticleId == 0)
            {
                UpdateArticle = new ArticlesModel();
            }
            else
            {
                UpdateArticle = Mapper.Map<ArticlesModel>(Article);

                if (UpdateArticle.Type is not null)
                {
                    SelectedType = UpdateArticle!.Type!.Split(",").ToList();
                    foreach (var selectedType in SelectedType)
                    {
                        var item = ArticleTypes.FirstOrDefault(b => b.Value!.Equals(selectedType));
                        ArticleTypes.Remove(item!);
                    }
                }

                if (UpdateArticle.ArticleEmblem is not null)
                {
                    Image = UpdateArticle.ArticleEmblem!.Image!;
                }
            }
        }

        public async Task Submit()
        {
            var isValid = Validation();

            if (isValid)
            {
                ConvertSelectedTypes();
                if (Add)
                {
                    var mappedArticle = Mapper.Map<Articles>(UpdateArticle);
                        
                    var result = await ArticlesService.AddArticleAsync(mappedArticle);

                    NavigationManager.NavigateTo(result ? "/articles" : "/articles/add");
                }
                if (Edit)
                {
                    var mappedArticle = Mapper.Map<Articles>(UpdateArticle);

                    var result = await ArticlesService.EditArticleAsync(mappedArticle, ArticleId);

                    NavigationManager.NavigateTo(result ? $"/articles/{ArticleId}" : $"/articles/{ArticleId}/edit");
                }
            }
        }

        public bool Validation()
        {
            if (Image is not "None")
            {
                IsBadEmblem = false;
            }
            else
            {
                IsBadEmblem = true;
                return false;
            }

            return true;
        }

        public void AddArticleType(string selected)
        {
            SelectedType.Add(selected);

            var item = ArticleTypes.FirstOrDefault(b => b.Value!.Equals(selected));

            ArticleTypes.Remove(item!);
        }

        public void RemoveSelectedType(string item)
        {
            SelectedType.Remove(item);

            ArticleTypes.Add(new() { Content = item, Value = item });
        }

        public void ConvertSelectedTypes()
        {
            foreach (var item in SelectedType)
            {
                if (Value == 0)
                {
                    UpdateArticle!.Type = $"{item}";
                    Value++;
                }
                else
                {
                    UpdateArticle!.Type += $",{item}";
                }
            }
        }

        public void SelectedImage(ChangeEventArgs e)
        {
            var selected = e.Value?.ToString();

            Image = selected!;

            var articleEmblem = ArticleEmblem.FirstOrDefault(b => b.Image!.Equals(selected));

            UpdateArticle!.ArticleEmblemId = articleEmblem?.Id;
        }
    }
}
