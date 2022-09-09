using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Logic.ActionsService.ArticlesService;

namespace WodCatClone.Web.PageComponents.ActionsComponent.ArticlesComponent
{
    public partial class FilterArticlesComponent
    {
        [Parameter] public IEnumerable<Articles> Articles { get; set; }

        [Inject] public IArticlesService ArticlesService { get; set; }

        public string[] ArticleType =
        {
            "Кроссфит",
            "Тренировки",
            "Статьи",
            "Лёгкая атлетика",
            "Бодибилдинг",
            "Бокс",
            "Фитнесс",
            "Гиревой спорт",
            "Тяжелая атлетика"
        };

        public bool IsVisible { get; set; }

        public async Task Filter(string type)
        {
            Articles = await ArticlesService.GetAllArticles();

            Articles = Articles.Where(b => b.Type.Contains(type)).ToList();
        }

        public async Task Reset()
        {
            Articles = await ArticlesService.GetAllArticles();
        }
    }
}
